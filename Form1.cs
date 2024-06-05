using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ogrenci_Yurt_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantı baglan = new SqlBaglantı();
        private void Form1_Load(object sender, EventArgs e)
        {
            //combo boxa bölümleri çekme
            SqlCommand komut = new SqlCommand("select BölümAd from Bölümler1",baglan.baglantı());
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxÖGRBÖLÜM.Items.Add(dr[0]);
            }
            baglan.baglantı().Close();

            //Boş odaları comboboxa aktarma 
            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar1 where OdaKapasite != OdaAktif", baglan.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBOXODANO.Items.Add(dr2[0].ToString());
            }
            baglan.baglantı().Close();
        }
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Ögrenci Kayıt 
                SqlCommand komutkydt = new SqlCommand("insert into Ögrenci1 (ÖgrAd,ÖgrSoyad,ÖgrTc,ÖgrTelefon,ÖgrDogum,ÖgrBölüm,ÖgrMail,ÖgrOdaNo,ÖgrVeliAdSoyad,ÖgrVeliTelefon,ÖgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan.baglantı());
                komutkydt.Parameters.AddWithValue("@p1", txtÖGRad.Text);
                komutkydt.Parameters.AddWithValue("@p2", txtÖgrSoyad.Text);
                komutkydt.Parameters.AddWithValue("@p3", mskÖgrTc.Text);
                komutkydt.Parameters.AddWithValue("@p4", mskTELEFON.Text);
                komutkydt.Parameters.AddWithValue("@p5", mskDOGUMtrh.Text);
                komutkydt.Parameters.AddWithValue("@p6", comboBoxÖGRBÖLÜM.Text);
                komutkydt.Parameters.AddWithValue("@p7", textBoxMAİL.Text);
                komutkydt.Parameters.AddWithValue("@p8", cmbBOXODANO.Text);
                komutkydt.Parameters.AddWithValue("@p9", textBoxVeliADSOYAD.Text);
                komutkydt.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutkydt.Parameters.AddWithValue("@p11", rchtxtAdres.Text);
                komutkydt.ExecuteNonQuery();
                MessageBox.Show("Kaydınız yapıldı");
                baglan.baglantı().Close();

                //Ögrenci ID labele çekme 
                SqlCommand komut2 = new SqlCommand("Select ÖgrId from Ögrenci1", baglan.baglantı());
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    label13.Text = dr[0].ToString();
                }
                baglan.baglantı().Close();

                //Ögrenci borç oluşturma
                SqlCommand komut = new SqlCommand("insert into Borçlar1 (ÖgrId,ÖgrAd,ÖgrSoyad) values (@b1,@b2,@b3)", baglan.baglantı());
                komut.Parameters.AddWithValue("@b1", label13.Text);
                komut.Parameters.AddWithValue("@b2", txtÖGRad.Text);
                komut.Parameters.AddWithValue("@b3", txtÖgrSoyad.Text);
                komut.ExecuteNonQuery();
                baglan.baglantı().Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }

            //Ögrenci oda kontenjan arttırma
            SqlCommand komtoda = new SqlCommand("update Odalar1 set OdaAktif=OdaAktif+1 where OdaNo=@o1", baglan.baglantı());
            komtoda.Parameters.AddWithValue("@o1", cmbBOXODANO.Text);
            komtoda.ExecuteNonQuery();
            baglan.baglantı().Close();
        }


    }
}
