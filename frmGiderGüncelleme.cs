using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmGiderGüncelleme : Form
    {
        public frmGiderGüncelleme()
        {
            InitializeComponent();
        }
        public string giderId, elektrik, su, dogalgaz, internet, gıda, personel, diger;
        SqlBaglantı bgl = new SqlBaglantı();
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Giderleri Güncelleme
                SqlCommand komut = new SqlCommand("update Giderler1 set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,İnternet=@p4,Gıda=@p5,PersonelGider=@p6,Diger=@p7 where ÖdemeId=@p8", bgl.baglantı());
                komut.Parameters.AddWithValue("@p8", textBox1.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrikgider.Text);
                komut.Parameters.AddWithValue("@p2", txtSugider.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgazgider.Text);
                komut.Parameters.AddWithValue("@p4", txtinternetgider.Text);
                komut.Parameters.AddWithValue("@p5", txtgıdagider.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonelgider.Text);
                komut.Parameters.AddWithValue("@p7", txtdigergiderler.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Kayıt güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı, Tekrar deneyin");
            }
        }
        private void frmGiderGüncelleme_Load(object sender, EventArgs e)
        {
            //Gider listesinde tıklanan hücreden veri çekme
            textBox1.Text = giderId;
            txtElektrikgider.Text = elektrik;
            txtSugider.Text = su;
            txtDogalgazgider.Text = dogalgaz;
            txtinternetgider.Text = internet;
            txtgıdagider.Text = gıda;
            txtPersonelgider.Text = personel;
            txtdigergiderler.Text = diger;
        }
    }
}
