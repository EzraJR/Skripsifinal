using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace frm_select.view
{
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public main()
        {
            InitializeComponent();
            Preprocessing_Data.proses = false;
        }

        private void main_Load(object sender, EventArgs e)
        {
            panelControl.Visible = false;

        }

        Import_Data frm_import = new Import_Data();
        Preprocessing_Data frm_preprocessing = new Preprocessing_Data();
        form_asosiasi frm_asosiasi = new form_asosiasi();

        private void BtnImport_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_import);

        }

        private void btnAtribut_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void btnCleaning_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_import);
        }

        private void btnFrekuensi_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_import);
        }

        private void btnSorting_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_import);
        }

        private void btnAsosiasi_ItemClick(object sender, TileItemEventArgs e)
        {
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_asosiasi);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            panelControl.Visible = false;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            panelControl.Visible = true;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(frm_preprocessing);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuControl_Click(object sender, EventArgs e)
        {

        }
    }
}