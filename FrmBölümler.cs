using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class FrmBölümler : Form
    {
        public FrmBölümler()
        {
            InitializeComponent();
        }
        SqlBaglantı baglantı = new SqlBaglantı();
        private void FrmBölümler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet2.Bölümler1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bölümler1TableAdapter.Fill(this.yurtKayıtSistemiDataSet2.Bölümler1);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //Bölüm ekleme
                SqlCommand komutekle = new SqlCommand("insert into Bölümler1 (BölümAd) values (@p1)", baglantı.baglantı());
                komutekle.Parameters.AddWithValue("@p1", textBoxBölümad.Text);
                komutekle.ExecuteNonQuery();
                baglantı.baglantı().Close();
                this.bölümler1TableAdapter.Fill(this.yurtKayıtSistemiDataSet2.Bölümler1);
                MessageBox.Show("Yeni Bölüm Başarıyla eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş tekrar deneyin");
            }
        }
        private void picturesilme_Click(object sender, EventArgs e)
        {
            try
            {
                //Bölüm Silme
                SqlCommand komutsil = new SqlCommand("delete from Bölümler1 where BölümId=@p1", baglantı.baglantı());
                komutsil.Parameters.AddWithValue("@p1", textBoxIDblm.Text);
                komutsil.ExecuteNonQuery();
                baglantı.baglantı().Close();
                MessageBox.Show("Bölüm Silindi");
                this.bölümler1TableAdapter.Fill(this.yurtKayıtSistemiDataSet2.Bölümler1);
                textBoxBölümad.Text = "";
                textBoxIDblm.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı tekrar deneyin");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bölümAd;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bölümAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxIDblm.Text = id;
            textBoxBölümad.Text = bölümAd;

        }
        private void picturegüncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                //Bölüm güncelleme 
                SqlCommand komutgncl = new SqlCommand("Update Bölümler1 set BölümAd=@p1 where BölümId=@p2", baglantı.baglantı());
                komutgncl.Parameters.AddWithValue("@p1", textBoxBölümad.Text);
                komutgncl.Parameters.AddWithValue("@p2", textBoxIDblm.Text);
                komutgncl.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi");
                baglantı.baglantı().Close();
                this.bölümler1TableAdapter.Fill(this.yurtKayıtSistemiDataSet2.Bölümler1);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
    }
}
