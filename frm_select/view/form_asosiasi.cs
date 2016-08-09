﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using frm_select.dao;
using System.Text.RegularExpressions;

namespace frm_select.view
{
    public partial class form_asosiasi : DevExpress.XtraEditors.XtraUserControl
    {
        const string connection = @"server = 127.0.0.1; port = 3306; UID = root; PWD = ; database=miningcontin";
        MySqlConnection _conn = new MySqlConnection(connection);
        private CFPTree _fpTreeGlobal;
        private double _minConf;
        private double _conf;
        public static List<Item> _frequentItems;
        public static List<ItemSet> _itemSetGlobal;

        import_dao model = new import_dao();

        public form_asosiasi()
        {
            InitializeComponent();
        }

        //aksi ketika form dibuka
        private void form_asosiasi_Load(object sender, EventArgs e)
        {

            _frequentItems = Preprocessing_Data.FrequentItems;
            _itemSetGlobal = Preprocessing_Data.ItemSetGlobal;

            string query = "select count(*)as total_item, sum(frekuensi) as total_frek from frekuensi";
            DataTable dt = new DataTable();
            var cmd = _conn.CreateCommand();

            _conn.Open();
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            dt.Load(reader);
            _conn.Close();


            minSupCount = Convert.ToInt16(dt.Rows[0].ItemArray[1]) / Convert.ToInt16(dt.Rows[0].ItemArray[0]);
            
        }

        //aksi ketika klik button proses
        int minSupCount;
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (teConfidence.Text != "")
            {

                minSupCount = Convert.ToInt16(teSupport.Text);
                _minConf = Convert.ToDouble(teConfidence.Text);

                //pembuatan cfp tree
                _fpTreeGlobal = new CFPTree(_frequentItems, _itemSetGlobal, minSupCount);
                teRules.ResetText();

                //pembuatan generate item set
                GenerateFrequentItemSets();
            }
            else
            {
                MessageBox.Show("Minimum Confidence tidak boleh kosong!");
            }
        }



       //membuat frequent item set dari cfp tree dan menampilkan hasil
        private int _totalAb;
        private int _totalA;

        private void GenerateFrequentItemSets()
        {
            var frequentItems = _fpTreeGlobal.FrequentItems;
            System.Diagnostics.Debug.WriteLine("This is the frequent items:");
            var patternItems = new List<List<ItemSet>>();

            foreach (var anItem in frequentItems)
            {
                var anItemSet = new ItemSet();
                anItemSet.AddItem(anItem);
                Console.WriteLine(@"Mine this -> " + anItem.Symbol);
                Mine(_fpTreeGlobal, anItemSet);
                if (_mamas.Count <= 0) continue;
                patternItems.Add(_mamas);

                foreach (var thisitem
                    in from itemSet
                    in _mamas
                       let thisitem = itemSet.Items.Aggregate("set: ", (current, item) => current + (item.Symbol + ", "))
                       select thisitem + (" - " + itemSet.Coda))
                {
                    Console.WriteLine(thisitem);
                }

                _mamas = new List<ItemSet>();
            }

            var dt = new DataTable();

            dt.Columns.Add("Rule");
            dt.Columns.Add("Support");
            dt.Columns.Add("Confidence");
            var forcon = "";
            var forcon2 = "";

            _conn.Open();
            var cmd1 = new MySqlCommand("Truncate rules", _conn);
            var reader1 = cmd1.ExecuteReader();
            reader1.Close();

            var c = 0;
            var jumlahPaket = 1 ;
            foreach (var t in patternItems)
            {
                bool doPRocess = true;
                foreach (var t1 in t)
                {
                    doPRocess = true;
                    var row = t1.Items;
                    var itemList = row.Select(item => item.Symbol).ToList();
                    _totalAb = _itemSetGlobal
                        .Select(t2 => t2.Items.Select(item => item.Symbol).ToList())
                        .Select(itemset => itemset.Intersect(itemList)).Count(isectList => isectList.Count() >= row.Count);
                    _totalA = frequentItems.Find(x => x.Symbol.Equals(row[0].Symbol)).SupportCount;

                    Console.WriteLine(_totalAb + @" - " + _totalA);

                    _conf = (_totalAb * 1.0 / _totalA * 1.0) * (100 * 1.0);

                    if ((_conf) >= _minConf)
                    {
                        //rules 1
                        var conclusion = "Setelan ke " +(jumlahPaket) + " adalah ";
                        var sup = (_totalAb * 1.0 / _itemSetGlobal.Count * 1.0) * (100 * 1.0);

                        var itemPaket = row[0].Symbol;
                        var items = row[0].Symbol + " -> { ";
                        for (var k = 1; k < row.Count; k++)
                        {
                            items += t1.Items[k].Symbol + " ,";
                            itemPaket += " , "+t1.Items[k].Symbol ;

                        }

                        items = items.Substring(0, items.Length - 2);
                        itemPaket +=". ";
                        items += " }";

                        c++;
                        conclusion += itemPaket;

                        //rule2 2
                        var conclusion2 = "Dengan confidence sebesar : " + _conf;

                        if (Regex.IsMatch(conclusion, "Sarung") == true &&
                            Regex.IsMatch(conclusion, "Sorban") == true &&
                            Regex.IsMatch(conclusion, "Baju Taqwa") == true &&
                            Regex.IsMatch(conclusion, "Sajadah") == true &&
                            Regex.IsMatch(conclusion, "Mukena") != true &&
                            Regex.IsMatch(conclusion, "Kerudung") != true)
                        { doPRocess = true; }
                        else if (Regex.IsMatch(conclusion, "Sorban") == true &&
                                Regex.IsMatch(conclusion, "Baju Taqwa") == true &&
                                Regex.IsMatch(conclusion, "Mukena") != true &&
                                Regex.IsMatch(conclusion, "Kerudung") != true)
                        { doPRocess = true; }
                        else if (Regex.IsMatch(conclusion, "Sajadah") == true &&
                           Regex.IsMatch(conclusion, "Baju Taqwa") == true &&
                           Regex.IsMatch(conclusion, "Mukena") != true &&
                           Regex.IsMatch(conclusion, "Kerudung") != true)
                        { doPRocess = true; }
                        else if (Regex.IsMatch(conclusion, "Sarung") == true &&
                          Regex.IsMatch(conclusion, "Baju Taqwa") == true &&
                          Regex.IsMatch(conclusion, "Mukena") != true &&
                          Regex.IsMatch(conclusion, "Kerudung") != true)
                        { doPRocess = true; }
                        else if (Regex.IsMatch(conclusion, "Mukena") == true &&
                                Regex.IsMatch(conclusion, "Kerudung") == true &&
                                Regex.IsMatch(conclusion, "Baju Taqwa") != true &&
                                Regex.IsMatch(conclusion, "Sorban") != true &&
                                Regex.IsMatch(conclusion, "Sarung") != true)
                        { doPRocess = true; }
                        else { doPRocess = false; }

                        if (doPRocess == true)
                        {
                            jumlahPaket++;
                            //gabung
                            teRules.Text += conclusion + conclusion2 + "\n\n";
                            forcon = "";

                            object[] arr = { items, Math.Round(sup, 2) + "%", Math.Round(_conf, 2) + "%" };
                            dt.Rows.Add(arr);

                            var cmd =
                                new MySqlCommand(
                                    "INSERT INTO rules VALUES('" + items + "', " + sup + "," + _conf + ")",
                                    _conn);
                            var reader = cmd.ExecuteReader();
                            reader.Close();
                        }
                        

                    }
                    _totalAb = 0;
                }
            }
            _conn.Close();

            gcAsosiasi.DataSource = dt;
        }

        List<ItemSet> _mamas = new List<ItemSet>();
        private void Mine(CFPTree fpTree, ItemSet anItemSet)
        {
            var projectedTree = fpTree.Project(anItemSet.GetLastItem());
            foreach (var anItem in projectedTree.FrequentItems)
            {
                Console.WriteLine(@"Next mine: " + anItem.Symbol);
                var nextItemSet = anItemSet.Clone();
                nextItemSet.AddItem(anItem);

                var setOfItem = nextItemSet.Clone();
                _mamas.Add(setOfItem);

                Mine(projectedTree, nextItemSet);
            }
        }
 

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


