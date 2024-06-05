using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmGeliristatistik : Form
    {
        public frmGeliristatistik()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void frmGeliristatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki miktarı çekme
            SqlCommand komut = new SqlCommand("Select Sum(ÖdemeMiktar) from Kasa1", bgl.baglantı());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelpara.Text = dr[0].ToString();
            }
            bgl.baglantı().Close();
            //Tekrarsız ay listeleme
            SqlCommand komut2 = new SqlCommand("Select distinct(ÖdemeAy) from Kasa1", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbsçlnay.Items.Add(dr2[0].ToString());
            }
            bgl.baglantı().Close();
            //Grafiklere(chart) veritabanından veri çekme
            SqlCommand komut3 = new SqlCommand("select ÖdemeAy,sum(ÖdemeMiktar) from Kasa1 group by ÖdemeAy", bgl.baglantı());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                this.chart1.Series["AYLIK"].Points.AddXY(dr3[0], dr3[1]);
            }
            bgl.baglantı().Close();
        }
        private void cmbsçlnay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen aya göre ödeme miktarlarını toplayıp labele çekme
            SqlCommand komut3 = new SqlCommand("Select Sum(ÖdemeMiktar) from Kasa1 where ÖdemeAy=@e1", bgl.baglantı());
            komut3.Parameters.AddWithValue("@e1", cmbsçlnay.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelSçlnaymktr.Text = dr3[0].ToString();
            }
            bgl.baglantı().Close();
        }
    }
}
