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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltcyer.Text = TC;
            //ad soyad ekliyorum
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from TableDoktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltcyer.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyadyer.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Sadece bu doktora ait randevular görünecek
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TableRandevular where RandevuDoktor='" + lbladsoyadyer.Text + "'", bgl.baglanti());
            da.Fill(dt);
            gridrandevulistesi.DataSource = dt;
        }

        private void gridrandevulistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = lbltcyer.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridrandevulistesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = gridrandevulistesi.SelectedCells[0].RowIndex;
            richsikayet.Text = gridrandevulistesi.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
