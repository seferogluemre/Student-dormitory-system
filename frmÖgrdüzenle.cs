using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmÖgrdüzenle : Form
    {
        public frmÖgrdüzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, Tc, Ögrtel, dogmtrh, ögrbölüm, mail, odaNo;
        private void buttonSİl_Click(object sender, EventArgs e)
        {
            //Ögrenci silme
            SqlCommand komtsil = new SqlCommand("Delete from Ögrenci1 where ÖgrId=@k1", bgl.baglantı());
            komtsil.Parameters.AddWithValue("@k1", textBoxÖgrId.Text);
            komtsil.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt silindi");

            //Odanın aktif ögrenci sayısını azaltma
            SqlCommand komtaz = new SqlCommand("update Odalar1 set OdaAktif=OdaAktif-1 where OdaNo=@oda1", bgl.baglantı());
            komtaz.Parameters.AddWithValue("@oda1", cmbBOXODANO.Text);
            komtaz.ExecuteNonQuery();
            bgl.baglantı().Close();
            temizle();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void butonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                //Ögrenci güncelleme düzenleme
                SqlCommand komut = new SqlCommand("update Ögrenci1 set ÖgrAd=@p2,ÖgrSoyad=@p3,ÖgrTc=@p4,ÖgrTelefon=@p5,ÖgrDogum=@p6,ÖgrBölüm=@p7,ÖgrMail=@p8,ÖgrOdaNo=@p9,ÖgrVeliAdSoyad=@p10,ÖgrVeliTelefon=@p11,ÖgrVeliAdres=@p12 where ÖgrId=@p1", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", textBoxÖgrId.Text);
                komut.Parameters.AddWithValue("@p2", txtÖGRad.Text);
                komut.Parameters.AddWithValue("@p3", txtÖgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskÖgrTc.Text);
                komut.Parameters.AddWithValue("@p5", mskTELEFON.Text);
                komut.Parameters.AddWithValue("@p6", mskDOGUMtrh.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxÖGRBÖLÜM.Text);
                komut.Parameters.AddWithValue("@p8", textBoxMAİL.Text);
                komut.Parameters.AddWithValue("@p9", cmbBOXODANO.Text);
                komut.Parameters.AddWithValue("@p10", textBoxVeliADSOYAD.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchtxtAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!,Yeniden Deneyin");
            }
        }
        public string veliAD, velitel, veliadres;
        private void frmÖgrdüzenle_Load(object sender, EventArgs e)
        {
            textBoxÖgrId.Text = id;
            txtÖGRad.Text = ad;
            txtÖgrSoyad.Text = soyad;
            mskÖgrTc.Text = Tc;
            mskTELEFON.Text = Ögrtel;
            mskDOGUMtrh.Text = dogmtrh;
            comboBoxÖGRBÖLÜM.Text = ögrbölüm;
            textBoxMAİL.Text = mail;
            cmbBOXODANO.Text = odaNo;
            textBoxVeliADSOYAD.Text = veliAD;
            mskVeliTelefon.Text = velitel;
            rchtxtAdres.Text = veliadres;
        }
        void temizle()
        {
            textBoxÖgrId.Text = "";
            txtÖGRad.Text = "";
            txtÖgrSoyad.Text = "";
            mskÖgrTc.Text = "";
            mskTELEFON.Text = "";
            mskDOGUMtrh.Text = "";
            comboBoxÖGRBÖLÜM.Text = "";
            cmbBOXODANO.Text = "";
            textBoxMAİL.Text = "";
            textBoxVeliADSOYAD.Text = "";
            mskVeliTelefon.Text = "";
            rchtxtAdres.Text = "";
        }
    }
}
