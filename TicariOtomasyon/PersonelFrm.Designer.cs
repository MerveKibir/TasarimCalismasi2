
namespace TicariOtomasyon
{
    partial class PersonelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnClean = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbIlce = new DevExpress.XtraEditors.LookUpEdit();
            this.maskTc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.maskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGorev = new DevExpress.XtraEditors.TextEdit();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbIl = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.BtnClean);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Location = new System.Drawing.Point(15, 15);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1335, 274);
            this.groupControl1.TabIndex = 4;
            // 
            // BtnClean
            // 
            this.BtnClean.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClean.Appearance.Options.UseFont = true;
            this.BtnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClean.ImageOptions.Image")));
            this.BtnClean.Location = new System.Drawing.Point(1060, 180);
            this.BtnClean.Margin = new System.Windows.Forms.Padding(10);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(171, 48);
            this.BtnClean.TabIndex = 24;
            this.BtnClean.Text = "Temizle";
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(1060, 55);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(171, 48);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbIlce);
            this.panelControl1.Controls.Add(this.maskTc);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.id);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Controls.Add(this.maskTel1);
            this.panelControl1.Controls.Add(this.rchAdres);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtGorev);
            this.panelControl1.Controls.Add(this.txtemail);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtAd);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtSoyad);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cbIl);
            this.panelControl1.Location = new System.Drawing.Point(10, 10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 249);
            this.panelControl1.TabIndex = 23;
            // 
            // cbIlce
            // 
            this.cbIlce.Location = new System.Drawing.Point(606, 122);
            this.cbIlce.Margin = new System.Windows.Forms.Padding(6);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIlce.Properties.Appearance.Options.UseFont = true;
            this.cbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIlce.Properties.DisplayMember = "Ilce";
            this.cbIlce.Properties.NullText = "";
            this.cbIlce.Properties.PopupSizeable = false;
            this.cbIlce.Properties.ValueMember = "Id";
            this.cbIlce.Size = new System.Drawing.Size(346, 24);
            this.cbIlce.TabIndex = 51;
            // 
            // maskTc
            // 
            this.maskTc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskTc.Location = new System.Drawing.Point(606, 12);
            this.maskTc.Margin = new System.Windows.Forms.Padding(6);
            this.maskTc.Mask = "00000000000";
            this.maskTc.Name = "maskTc";
            this.maskTc.Size = new System.Drawing.Size(346, 26);
            this.maskTc.TabIndex = 49;
            this.maskTc.ValidatingType = typeof(int);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 160);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 19);
            this.labelControl10.TabIndex = 47;
            this.labelControl10.Text = "Görev:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(506, 160);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 19);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "Adres:";
            // 
            // id
            // 
            this.id.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id.Appearance.Options.UseFont = true;
            this.id.Appearance.Options.UseForeColor = true;
            this.id.Location = new System.Drawing.Point(23, 15);
            this.id.Margin = new System.Windows.Forms.Padding(6);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(22, 19);
            this.id.TabIndex = 30;
            this.id.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(164, 13);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(286, 24);
            this.txtId.TabIndex = 31;
            // 
            // maskTel1
            // 
            this.maskTel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskTel1.Location = new System.Drawing.Point(164, 121);
            this.maskTel1.Margin = new System.Windows.Forms.Padding(6);
            this.maskTel1.Mask = "(999) 000-0000";
            this.maskTel1.Name = "maskTel1";
            this.maskTel1.Size = new System.Drawing.Size(286, 26);
            this.maskTel1.TabIndex = 32;
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(606, 158);
            this.rchAdres.Margin = new System.Windows.Forms.Padding(6);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(346, 63);
            this.rchAdres.TabIndex = 45;
            this.rchAdres.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(506, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "TC No:";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(164, 158);
            this.txtGorev.Margin = new System.Windows.Forms.Padding(6);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorev.Properties.Appearance.Options.UseFont = true;
            this.txtGorev.Properties.Mask.BeepOnError = true;
            this.txtGorev.Properties.Mask.EditMask = "n2";
            this.txtGorev.Size = new System.Drawing.Size(286, 24);
            this.txtGorev.TabIndex = 44;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(606, 50);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtemail.Properties.Appearance.Options.UseFont = true;
            this.txtemail.Size = new System.Drawing.Size(346, 24);
            this.txtemail.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 52);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 19);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Ad:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(506, 125);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 19);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "İlçe:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(164, 49);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(286, 24);
            this.txtAd.TabIndex = 36;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(506, 92);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 19);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "İl:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 88);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 19);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Soyad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(506, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 19);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "E-Mail:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(164, 85);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(286, 24);
            this.txtSoyad.TabIndex = 38;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 124);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 19);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Tel 1:";
            // 
            // cbIl
            // 
            this.cbIl.Location = new System.Drawing.Point(606, 86);
            this.cbIl.Margin = new System.Windows.Forms.Padding(6);
            this.cbIl.Name = "cbIl";
            this.cbIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIl.Properties.Appearance.Options.UseFont = true;
            this.cbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIl.Properties.DisplayMember = "Il";
            this.cbIl.Properties.NullText = "";
            this.cbIl.Properties.PopupSizeable = false;
            this.cbIl.Properties.ValueMember = "Plaka";
            this.cbIl.Size = new System.Drawing.Size(346, 24);
            this.cbIl.TabIndex = 50;
            this.cbIl.EditValueChanged += new System.EventHandler(this.cbIl_EditValueChanged);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(1060, 115);
            this.btnSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(171, 47);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(15, 301);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1335, 243);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // PersonelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "PersonelFrm";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.PersonelFrm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnClean;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbIlce;
        private System.Windows.Forms.MaskedTextBox maskTc;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl id;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.MaskedTextBox maskTel1;
        private System.Windows.Forms.RichTextBox rchAdres;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGorev;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cbIl;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}