using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void textBoxÖgrId_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxPersonID.BackColor = Color.Gainsboro;
            }
        }
        private void txtbxPersonID_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxPersonID.BackColor = Color.White;
            }
        }
        private void txtbxpersonad_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxpersonad.BackColor = Color.Gainsboro;
            }
        }
        private void txtbxpersonad_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxpersonad.BackColor = Color.White;
            }
        }
        private void txtbxpersongörev_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxpersongörev.BackColor = Color.Gainsboro;
            }
        }
        private void txtbxpersongörev_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                txtbxpersongörev.BackColor = Color.White;
            }
        }
        private void frmpersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet8.Personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.yurtKayıtSistemiDataSet8.Personel1);
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //Person ekleme
            SqlCommand kmtekle = new SqlCommand("insert into Personel1 (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglantı());
            kmtekle.Parameters.AddWithValue("@p1", txtbxpersonad.Text);
            kmtekle.Parameters.AddWithValue("@p2", txtbxpersongörev.Text);
            kmtekle.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Personel EKlendi!");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet8.Personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.yurtKayıtSistemiDataSet8.Personel1);
        }
        private void buttonsil_Click(object sender, EventArgs e)
        {
            //Personel silme
            SqlCommand komutsl = new SqlCommand("Delete from Personel1 where PersonelId=@y1", bgl.baglantı());
            komutsl.Parameters.AddWithValue("@y1", txtbxPersonID.Text);
            komutsl.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Personel Silindi");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet8.Personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.yurtKayıtSistemiDataSet8.Personel1);
            txtbxpersonad.Text = "";
            txtbxpersongörev.Text = "";
            txtbxPersonID.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrid hücre tıklandıgında nesnelere veri aktarımı
            int seçen;
            seçen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, görev;

            id = dataGridView1.Rows[seçen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçen].Cells[1].Value.ToString();
            görev = dataGridView1.Rows[seçen].Cells[2].Value.ToString();

            txtbxPersonID.Text = id;
            txtbxpersonad.Text = ad;
            txtbxpersongörev.Text = görev;
        }
        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            //Personel bilgi güncelleme
            SqlCommand kmtgüncel = new SqlCommand("update Personel1 set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelId=@p3", bgl.baglantı());
            kmtgüncel.Parameters.AddWithValue("@p1", txtbxpersonad.Text);
            kmtgüncel.Parameters.AddWithValue("@p2", txtbxpersongörev.Text);
            kmtgüncel.Parameters.AddWithValue("@p3", txtbxPersonID.Text);
            kmtgüncel.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Personel Güncellendi");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet8.Personel1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel1TableAdapter.Fill(this.yurtKayıtSistemiDataSet8.Personel1);
        }
    }
}
