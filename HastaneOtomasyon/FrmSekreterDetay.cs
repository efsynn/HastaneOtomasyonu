﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
       
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltcyer.Text = TCnumara;
            
            //Ad ve soyad geçiş
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from TableSekreterler where SekreterTC=@p1 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltcyer.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbladsoyadyer.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branşları giriyotum tablodan
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TableBrans", bgl.baglanti());
            da.Fill(dt1);
            gridbranslar.DataSource = dt1;

            //doktorları tablodan akterma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd+ ' '+DoktorSoyad) as Doktor ,DoktorBrans from TableDoktorlar", bgl.baglanti());
            da2.Fill(dt2);
            griddoktorlar.DataSource = dt2;

            //Branşı aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from TableBrans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TableRandevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text); 
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");

        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TableDoktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TableDuyurular(Duyuru) values(@d1) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richduyurular.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
