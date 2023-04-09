using System;
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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltcyer.Text = tc;
            //ad soyad aldım
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From tableHastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyadyer.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişini alıyorum burada
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TableRandevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            gridrandevugecmisi.DataSource = dt;

            //Branş ekliyorum
            SqlCommand komut2 = new SqlCommand("Select BransAd from TableBrans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
  
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From TableDoktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TableRandevular where RandevuBrans='" + cmbbrans.Text + "'"
                + "and RandevuDoktor='"+cmbdoktor.Text+"'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            gridaktifrandevular.DataSource = dt;
        }

        private void linkbilgilriniguncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lbltc.Text;
            fr.Show();
        }
        private void gridaktifrandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = gridaktifrandevular.SelectedCells[0].RowIndex;
            txtid.Text = gridaktifrandevular.Rows[secilen].Cells[0].Value.ToString();
        }
        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TableRandevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", richsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
 