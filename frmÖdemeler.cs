using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmÖdemeler : Form
    {
        public frmÖdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void frmÖdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet4.Borçlar1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borçlar1TableAdapter.Fill(this.yurtKayıtSistemiDataSet4.Borçlar1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBoxÖgrId.Text = id;
            textbxÖgrad.Text = ad;
            textboxÖgrsoyad.Text = soyad;
            txtKalanborç.Text = kalan;
        }
        private void butonÖdemeal_Click(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan tutardan düşürme
            int ödenen, kalan, yeniborç;
            ödenen = Convert.ToInt16(textBoxÖdenen.Text);
            kalan = Convert.ToInt16(txtKalanborç.Text);
            yeniborç = kalan - ödenen;
            txtKalanborç.Text = yeniborç.ToString();

            //Yeni tutarı databaseye aktarma
            SqlCommand komutgncl = new SqlCommand("update Borçlar1 set ÖgrKalanBorç=@p1 where ÖgrId=@p2", bgl.baglantı());
            komutgncl.Parameters.AddWithValue("@p1", txtKalanborç.Text);
            komutgncl.Parameters.AddWithValue("@p2", textBoxÖgrId.Text);
            komutgncl.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Borç Ödendi!");
            this.borçlar1TableAdapter.Fill(this.yurtKayıtSistemiDataSet4.Borçlar1);

            //Kasa tablosuna deger girişi
            SqlCommand komut2 = new SqlCommand("insert into Kasa1 (ÖdemeAy,ÖdemeMiktar) values (@k1,@k2)", bgl.baglantı());
            komut2.Parameters.AddWithValue("@k1", textBoxÖdenenAY.Text);
            komut2.Parameters.AddWithValue("@k2", textBoxÖdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
        }
    }
}
