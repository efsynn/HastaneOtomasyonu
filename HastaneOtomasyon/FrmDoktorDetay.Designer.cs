
namespace HastaneOtomasyon
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.grpdoktorbilgi = new System.Windows.Forms.GroupBox();
            this.lbladsoyadyer = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltcyer = new System.Windows.Forms.Label();
            this.grprandevudetay = new System.Windows.Forms.GroupBox();
            this.richsikayet = new System.Windows.Forms.RichTextBox();
            this.grprandevulistesi = new System.Windows.Forms.GroupBox();
            this.gridrandevulistesi = new System.Windows.Forms.DataGridView();
            this.grphizlierisim = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnbilgiduzenle = new System.Windows.Forms.Button();
            this.grpdoktorbilgi.SuspendLayout();
            this.grprandevudetay.SuspendLayout();
            this.grprandevulistesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridrandevulistesi)).BeginInit();
            this.grphizlierisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdoktorbilgi
            // 
            this.grpdoktorbilgi.Controls.Add(this.lbladsoyadyer);
            this.grpdoktorbilgi.Controls.Add(this.lbltc);
            this.grpdoktorbilgi.Controls.Add(this.lbladsoyad);
            this.grpdoktorbilgi.Controls.Add(this.lbltcyer);
            this.grpdoktorbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpdoktorbilgi.Location = new System.Drawing.Point(34, 28);
            this.grpdoktorbilgi.Name = "grpdoktorbilgi";
            this.grpdoktorbilgi.Size = new System.Drawing.Size(246, 150);
            this.grpdoktorbilgi.TabIndex = 0;
            this.grpdoktorbilgi.TabStop = false;
            this.grpdoktorbilgi.Text = "Doktor Bilgi";
            // 
            // lbladsoyadyer
            // 
            this.lbladsoyadyer.AutoSize = true;
            this.lbladsoyadyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyadyer.Location = new System.Drawing.Point(123, 87);
            this.lbladsoyadyer.Name = "lbladsoyadyer";
            this.lbladsoyadyer.Size = new System.Drawing.Size(101, 20);
            this.lbladsoyadyer.TabIndex = 9;
            this.lbladsoyadyer.Text = "____  ____";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(32, 43);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(39, 20);
            this.lbltc.TabIndex = 6;
            this.lbltc.Text = "TC:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.Location = new System.Drawing.Point(23, 87);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(94, 20);
            this.lbladsoyad.TabIndex = 7;
            this.lbladsoyad.Text = "Ad Soyad:";
            // 
            // lbltcyer
            // 
            this.lbltcyer.AutoSize = true;
            this.lbltcyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcyer.Location = new System.Drawing.Point(99, 43);
            this.lbltcyer.Name = "lbltcyer";
            this.lbltcyer.Size = new System.Drawing.Size(119, 20);
            this.lbltcyer.TabIndex = 8;
            this.lbltcyer.Text = "___________";
            // 
            // grprandevudetay
            // 
            this.grprandevudetay.Controls.Add(this.richsikayet);
            this.grprandevudetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grprandevudetay.Location = new System.Drawing.Point(34, 198);
            this.grprandevudetay.Name = "grprandevudetay";
            this.grprandevudetay.Size = new System.Drawing.Size(246, 123);
            this.grprandevudetay.TabIndex = 1;
            this.grprandevudetay.TabStop = false;
            this.grprandevudetay.Text = "Randevu Detay";
            // 
            // richsikayet
            // 
            this.richsikayet.Location = new System.Drawing.Point(6, 21);
            this.richsikayet.Name = "richsikayet";
            this.richsikayet.Size = new System.Drawing.Size(234, 96);
            this.richsikayet.TabIndex = 0;
            this.richsikayet.Text = "";
            // 
            // grprandevulistesi
            // 
            this.grprandevulistesi.Controls.Add(this.gridrandevulistesi);
            this.grprandevulistesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grprandevulistesi.Location = new System.Drawing.Point(306, 28);
            this.grprandevulistesi.Name = "grprandevulistesi";
            this.grprandevulistesi.Size = new System.Drawing.Size(439, 424);
            this.grprandevulistesi.TabIndex = 2;
            this.grprandevulistesi.TabStop = false;
            this.grprandevulistesi.Text = "Randevu Listesi";
            // 
            // gridrandevulistesi
            // 
            this.gridrandevulistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridrandevulistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridrandevulistesi.Location = new System.Drawing.Point(3, 23);
            this.gridrandevulistesi.Name = "gridrandevulistesi";
            this.gridrandevulistesi.RowHeadersWidth = 51;
            this.gridrandevulistesi.RowTemplate.Height = 24;
            this.gridrandevulistesi.Size = new System.Drawing.Size(433, 398);
            this.gridrandevulistesi.TabIndex = 0;
            this.gridrandevulistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridrandevulistesi_CellClick);
            this.gridrandevulistesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridrandevulistesi_CellContentClick);
            // 
            // grphizlierisim
            // 
            this.grphizlierisim.Controls.Add(this.btncikis);
            this.grphizlierisim.Controls.Add(this.btnduyurular);
            this.grphizlierisim.Controls.Add(this.btnbilgiduzenle);
            this.grphizlierisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grphizlierisim.Location = new System.Drawing.Point(34, 343);
            this.grphizlierisim.Name = "grphizlierisim";
            this.grphizlierisim.Size = new System.Drawing.Size(240, 109);
            this.grphizlierisim.TabIndex = 3;
            this.grphizlierisim.TabStop = false;
            this.grphizlierisim.Text = "Hızlı Erişim";
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(7, 61);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(211, 31);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduyurular.Location = new System.Drawing.Point(119, 27);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(99, 31);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnbilgiduzenle
            // 
            this.btnbilgiduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgiduzenle.Location = new System.Drawing.Point(7, 27);
            this.btnbilgiduzenle.Name = "btnbilgiduzenle";
            this.btnbilgiduzenle.Size = new System.Drawing.Size(99, 31);
            this.btnbilgiduzenle.TabIndex = 0;
            this.btnbilgiduzenle.Text = "Bilgi Düzenle";
            this.btnbilgiduzenle.UseVisualStyleBackColor = true;
            this.btnbilgiduzenle.Click += new System.EventHandler(this.btnbilgiduzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(757, 476);
            this.Controls.Add(this.grphizlierisim);
            this.Controls.Add(this.grprandevulistesi);
            this.Controls.Add(this.grprandevudetay);
            this.Controls.Add(this.grpdoktorbilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.grpdoktorbilgi.ResumeLayout(false);
            this.grpdoktorbilgi.PerformLayout();
            this.grprandevudetay.ResumeLayout(false);
            this.grprandevulistesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridrandevulistesi)).EndInit();
            this.grphizlierisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdoktorbilgi;
        private System.Windows.Forms.Label lbladsoyadyer;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltcyer;
        private System.Windows.Forms.GroupBox grprandevudetay;
        private System.Windows.Forms.GroupBox grprandevulistesi;
        private System.Windows.Forms.DataGridView gridrandevulistesi;
        private System.Windows.Forms.RichTextBox richsikayet;
        private System.Windows.Forms.GroupBox grphizlierisim;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgiduzenle;
    }
}