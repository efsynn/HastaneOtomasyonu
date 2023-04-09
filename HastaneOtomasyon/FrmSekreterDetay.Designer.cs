
namespace HastaneOtomasyon
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.grpsekreterbilgi = new System.Windows.Forms.GroupBox();
            this.lbladsoyadyer = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltcyer = new System.Windows.Forms.Label();
            this.grpduyuruolustur = new System.Windows.Forms.GroupBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.richduyurular = new System.Windows.Forms.RichTextBox();
            this.grprandevupaneli = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.chkdurum = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbltcno = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.lblbrans = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.grpbranslar = new System.Windows.Forms.GroupBox();
            this.gridbranslar = new System.Windows.Forms.DataGridView();
            this.grpdoktorlar = new System.Windows.Forms.GroupBox();
            this.griddoktorlar = new System.Windows.Forms.DataGridView();
            this.grphizlierisim = new System.Windows.Forms.GroupBox();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.btnbranspaneli = new System.Windows.Forms.Button();
            this.btndoktorpaneli = new System.Windows.Forms.Button();
            this.grpsekreterbilgi.SuspendLayout();
            this.grpduyuruolustur.SuspendLayout();
            this.grprandevupaneli.SuspendLayout();
            this.grpbranslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbranslar)).BeginInit();
            this.grpdoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddoktorlar)).BeginInit();
            this.grphizlierisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpsekreterbilgi
            // 
            this.grpsekreterbilgi.Controls.Add(this.lbladsoyadyer);
            this.grpsekreterbilgi.Controls.Add(this.lbltc);
            this.grpsekreterbilgi.Controls.Add(this.lbladsoyad);
            this.grpsekreterbilgi.Controls.Add(this.lbltcyer);
            this.grpsekreterbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpsekreterbilgi.Location = new System.Drawing.Point(12, 27);
            this.grpsekreterbilgi.Name = "grpsekreterbilgi";
            this.grpsekreterbilgi.Size = new System.Drawing.Size(238, 119);
            this.grpsekreterbilgi.TabIndex = 0;
            this.grpsekreterbilgi.TabStop = false;
            this.grpsekreterbilgi.Text = "Sekreter Bilgi";
            // 
            // lbladsoyadyer
            // 
            this.lbladsoyadyer.AutoSize = true;
            this.lbladsoyadyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyadyer.Location = new System.Drawing.Point(119, 80);
            this.lbladsoyadyer.Name = "lbladsoyadyer";
            this.lbladsoyadyer.Size = new System.Drawing.Size(101, 20);
            this.lbladsoyadyer.TabIndex = 13;
            this.lbladsoyadyer.Text = "____  ____";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(28, 36);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(39, 20);
            this.lbltc.TabIndex = 10;
            this.lbltc.Text = "TC:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.Location = new System.Drawing.Point(19, 80);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(94, 20);
            this.lbladsoyad.TabIndex = 11;
            this.lbladsoyad.Text = "Ad Soyad:";
            // 
            // lbltcyer
            // 
            this.lbltcyer.AutoSize = true;
            this.lbltcyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcyer.Location = new System.Drawing.Point(95, 36);
            this.lbltcyer.Name = "lbltcyer";
            this.lbltcyer.Size = new System.Drawing.Size(119, 20);
            this.lbltcyer.TabIndex = 12;
            this.lbltcyer.Text = "___________";
            // 
            // grpduyuruolustur
            // 
            this.grpduyuruolustur.Controls.Add(this.btnolustur);
            this.grpduyuruolustur.Controls.Add(this.richduyurular);
            this.grpduyuruolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpduyuruolustur.Location = new System.Drawing.Point(12, 157);
            this.grpduyuruolustur.Name = "grpduyuruolustur";
            this.grpduyuruolustur.Size = new System.Drawing.Size(238, 245);
            this.grpduyuruolustur.TabIndex = 1;
            this.grpduyuruolustur.TabStop = false;
            this.grpduyuruolustur.Text = "Duyuru Oluştur";
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(6, 190);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(226, 38);
            this.btnolustur.TabIndex = 2;
            this.btnolustur.Text = "OLUŞTUR";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // richduyurular
            // 
            this.richduyurular.Location = new System.Drawing.Point(6, 26);
            this.richduyurular.Name = "richduyurular";
            this.richduyurular.Size = new System.Drawing.Size(226, 158);
            this.richduyurular.TabIndex = 2;
            this.richduyurular.Text = "";
            // 
            // grprandevupaneli
            // 
            this.grprandevupaneli.Controls.Add(this.btnkaydet);
            this.grprandevupaneli.Controls.Add(this.chkdurum);
            this.grprandevupaneli.Controls.Add(this.msktc);
            this.grprandevupaneli.Controls.Add(this.cmbdoktor);
            this.grprandevupaneli.Controls.Add(this.cmbbrans);
            this.grprandevupaneli.Controls.Add(this.msksaat);
            this.grprandevupaneli.Controls.Add(this.msktarih);
            this.grprandevupaneli.Controls.Add(this.txtid);
            this.grprandevupaneli.Controls.Add(this.lbltcno);
            this.grprandevupaneli.Controls.Add(this.lbldoktor);
            this.grprandevupaneli.Controls.Add(this.lblbrans);
            this.grprandevupaneli.Controls.Add(this.lblsaat);
            this.grprandevupaneli.Controls.Add(this.lbltarih);
            this.grprandevupaneli.Controls.Add(this.lblid);
            this.grprandevupaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grprandevupaneli.Location = new System.Drawing.Point(284, 27);
            this.grprandevupaneli.Name = "grprandevupaneli";
            this.grprandevupaneli.Size = new System.Drawing.Size(301, 375);
            this.grprandevupaneli.TabIndex = 2;
            this.grprandevupaneli.TabStop = false;
            this.grprandevupaneli.Text = "Randevu Paneli";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(104, 309);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(138, 36);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // chkdurum
            // 
            this.chkdurum.AutoSize = true;
            this.chkdurum.Location = new System.Drawing.Point(105, 268);
            this.chkdurum.Name = "chkdurum";
            this.chkdurum.Size = new System.Drawing.Size(87, 24);
            this.chkdurum.TabIndex = 14;
            this.chkdurum.Text = "Durum";
            this.chkdurum.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(105, 235);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(137, 27);
            this.msktc.TabIndex = 13;
            this.msktc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(104, 200);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(138, 28);
            this.cmbdoktor.TabIndex = 12;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(104, 166);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(138, 28);
            this.cmbbrans.TabIndex = 11;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(105, 130);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(137, 27);
            this.msksaat.TabIndex = 10;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(105, 92);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(137, 27);
            this.msktarih.TabIndex = 9;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(104, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(138, 27);
            this.txtid.TabIndex = 8;
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(59, 235);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(39, 20);
            this.lbltcno.TabIndex = 6;
            this.lbltcno.Text = "TC:";
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.Location = new System.Drawing.Point(27, 200);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(71, 20);
            this.lbldoktor.TabIndex = 5;
            this.lbldoktor.Text = "Doktor:";
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.Location = new System.Drawing.Point(33, 165);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.Size = new System.Drawing.Size(65, 20);
            this.lblbrans.TabIndex = 4;
            this.lblbrans.Text = "Branş:";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(45, 130);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(53, 20);
            this.lblsaat.TabIndex = 3;
            this.lblsaat.Text = "Saat:";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(40, 95);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(58, 20);
            this.lbltarih.TabIndex = 1;
            this.lbltarih.Text = "Tarih:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(68, 60);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id:";
            // 
            // grpbranslar
            // 
            this.grpbranslar.Controls.Add(this.gridbranslar);
            this.grpbranslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbranslar.Location = new System.Drawing.Point(608, 27);
            this.grpbranslar.Name = "grpbranslar";
            this.grpbranslar.Size = new System.Drawing.Size(339, 249);
            this.grpbranslar.TabIndex = 3;
            this.grpbranslar.TabStop = false;
            this.grpbranslar.Text = "Branşlar";
            // 
            // gridbranslar
            // 
            this.gridbranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridbranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridbranslar.Location = new System.Drawing.Point(3, 23);
            this.gridbranslar.Name = "gridbranslar";
            this.gridbranslar.RowHeadersWidth = 51;
            this.gridbranslar.RowTemplate.Height = 24;
            this.gridbranslar.Size = new System.Drawing.Size(333, 223);
            this.gridbranslar.TabIndex = 0;
            // 
            // grpdoktorlar
            // 
            this.grpdoktorlar.Controls.Add(this.griddoktorlar);
            this.grpdoktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpdoktorlar.Location = new System.Drawing.Point(608, 282);
            this.grpdoktorlar.Name = "grpdoktorlar";
            this.grpdoktorlar.Size = new System.Drawing.Size(339, 258);
            this.grpdoktorlar.TabIndex = 4;
            this.grpdoktorlar.TabStop = false;
            this.grpdoktorlar.Text = "Doktorlar";
            // 
            // griddoktorlar
            // 
            this.griddoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griddoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griddoktorlar.Location = new System.Drawing.Point(3, 23);
            this.griddoktorlar.Name = "griddoktorlar";
            this.griddoktorlar.RowHeadersWidth = 51;
            this.griddoktorlar.RowTemplate.Height = 24;
            this.griddoktorlar.Size = new System.Drawing.Size(333, 232);
            this.griddoktorlar.TabIndex = 1;
            // 
            // grphizlierisim
            // 
            this.grphizlierisim.Controls.Add(this.btnduyurular);
            this.grphizlierisim.Controls.Add(this.btnrandevuliste);
            this.grphizlierisim.Controls.Add(this.btnbranspaneli);
            this.grphizlierisim.Controls.Add(this.btndoktorpaneli);
            this.grphizlierisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grphizlierisim.Location = new System.Drawing.Point(12, 408);
            this.grphizlierisim.Name = "grphizlierisim";
            this.grphizlierisim.Size = new System.Drawing.Size(573, 129);
            this.grphizlierisim.TabIndex = 5;
            this.grphizlierisim.TabStop = false;
            this.grphizlierisim.Text = "Hızlı Erişim";
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(309, 68);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(138, 36);
            this.btnduyurular.TabIndex = 19;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Location = new System.Drawing.Point(309, 26);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(138, 36);
            this.btnrandevuliste.TabIndex = 18;
            this.btnrandevuliste.Text = "Randevu Liste";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // btnbranspaneli
            // 
            this.btnbranspaneli.Location = new System.Drawing.Point(82, 68);
            this.btnbranspaneli.Name = "btnbranspaneli";
            this.btnbranspaneli.Size = new System.Drawing.Size(138, 36);
            this.btnbranspaneli.TabIndex = 17;
            this.btnbranspaneli.Text = "Branş Paneli";
            this.btnbranspaneli.UseVisualStyleBackColor = true;
            this.btnbranspaneli.Click += new System.EventHandler(this.btnbranspaneli_Click);
            // 
            // btndoktorpaneli
            // 
            this.btndoktorpaneli.Location = new System.Drawing.Point(82, 26);
            this.btndoktorpaneli.Name = "btndoktorpaneli";
            this.btndoktorpaneli.Size = new System.Drawing.Size(138, 36);
            this.btndoktorpaneli.TabIndex = 16;
            this.btndoktorpaneli.Text = "Doktor Paneli";
            this.btndoktorpaneli.UseVisualStyleBackColor = true;
            this.btndoktorpaneli.Click += new System.EventHandler(this.btndoktorpaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(974, 572);
            this.Controls.Add(this.grphizlierisim);
            this.Controls.Add(this.grpdoktorlar);
            this.Controls.Add(this.grpbranslar);
            this.Controls.Add(this.grprandevupaneli);
            this.Controls.Add(this.grpduyuruolustur);
            this.Controls.Add(this.grpsekreterbilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter İşlemler";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.grpsekreterbilgi.ResumeLayout(false);
            this.grpsekreterbilgi.PerformLayout();
            this.grpduyuruolustur.ResumeLayout(false);
            this.grprandevupaneli.ResumeLayout(false);
            this.grprandevupaneli.PerformLayout();
            this.grpbranslar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridbranslar)).EndInit();
            this.grpdoktorlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.griddoktorlar)).EndInit();
            this.grphizlierisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpsekreterbilgi;
        private System.Windows.Forms.GroupBox grpduyuruolustur;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.RichTextBox richduyurular;
        private System.Windows.Forms.GroupBox grprandevupaneli;
        private System.Windows.Forms.Label lbladsoyadyer;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltcyer;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.CheckBox chkdurum;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.GroupBox grpbranslar;
        private System.Windows.Forms.DataGridView gridbranslar;
        private System.Windows.Forms.GroupBox grpdoktorlar;
        private System.Windows.Forms.DataGridView griddoktorlar;
        private System.Windows.Forms.GroupBox grphizlierisim;
        private System.Windows.Forms.Button btnrandevuliste;
        private System.Windows.Forms.Button btnbranspaneli;
        private System.Windows.Forms.Button btndoktorpaneli;
        private System.Windows.Forms.Button btnduyurular;
    }
}