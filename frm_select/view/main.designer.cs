namespace frm_select.view
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.menuControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.BtnImport = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.btnAsosiasi = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Groups.Add(this.tileGroup1);
            this.menuControl.Groups.Add(this.tileGroup4);
            this.menuControl.Location = new System.Drawing.Point(79, 191);
            this.menuControl.MaxId = 17;
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(873, 194);
            this.menuControl.TabIndex = 0;
            this.menuControl.Text = "tileControl1";
            this.menuControl.Click += new System.EventHandler(this.menuControl_Click);
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.BtnImport);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // BtnImport
            // 
            this.BtnImport.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnImport.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnImport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.BtnImport.AppearanceItem.Normal.Options.UseForeColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.Text = "Import Data";
            this.BtnImport.Elements.Add(tileItemElement1);
            this.BtnImport.Id = 0;
            this.BtnImport.IsLarge = true;
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.BtnImport_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.btnAsosiasi);
            this.tileGroup4.Name = "tileGroup4";
            this.tileGroup4.Text = null;
            // 
            // btnAsosiasi
            // 
            this.btnAsosiasi.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsosiasi.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.Text = "Asosiasi Data";
            this.btnAsosiasi.Elements.Add(tileItemElement2);
            this.btnAsosiasi.Id = 9;
            this.btnAsosiasi.IsLarge = true;
            this.btnAsosiasi.Name = "btnAsosiasi";
            this.btnAsosiasi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAsosiasi_ItemClick);
            // 
            // tileItem4
            // 
            tileItemElement3.Text = "Pengurutan";
            this.tileItem4.Elements.Add(tileItemElement3);
            this.tileItem4.Id = 13;
            this.tileItem4.Name = "tileItem4";
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(37, 179);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(948, 445);
            this.panelControl.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(122, 133);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(40, 37);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Cara Penggunaan";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(79, 133);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 37);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Pengaturan";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(36, 133);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(40, 37);
            this.BtnMenu.TabIndex = 15;
            this.BtnMenu.Text = "Beranda";
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Toko Subur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pasar Tanjung 308 Jember ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frm_select.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(310, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "APLIKASI REKOMENDASI SETELAN BUSANA MUSLIM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuControl);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLIKASI REKOMENDASI SETELAN BUSANA MUSLIM TOKO SUBUR";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl menuControl;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem BtnImport;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem btnAsosiasi;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.SimpleButton BtnMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl;
    }
}