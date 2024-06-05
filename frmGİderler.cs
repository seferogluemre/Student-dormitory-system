using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmGİderler : Form
    {
        public frmGİderler()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Giderleri tabloya çekme
                SqlCommand komut = new SqlCommand("insert into Giderler1 (Elektrik,Su,Dogalgaz,İnternet,Gıda,PersonelGider,Diger) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", txtElektrikgider.Text);
                komut.Parameters.AddWithValue("@p2", txtSugider.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgazgider.Text);
                komut.Parameters.AddWithValue("@p4", txtinternetgider.Text);
                komut.Parameters.AddWithValue("@p5", txtgıdagider.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonelgider.Text);
                komut.Parameters.AddWithValue("@p7", txtdigergiderler.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Kayıtlar Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu Tekrar deneyin");
            }

        }
    }
}
