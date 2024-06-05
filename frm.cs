using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void frm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet7.Admin1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.admin1TableAdapter.Fill(this.yurtKayıtSistemiDataSet7.Admin1);
        }
        void txtkulanıcıadmouseent()
        {
            for (int i = 0; i <= 400; i++) ;
            {
                txtboxyntckullancııad.BackColor = Color.Gainsboro;
            }
        }
        void txtkulanıcıadMouseleave()
        {
            for (int i = 0; i <= 400; i++) ;
            {
                txtboxyntckullancııad.BackColor = Color.White;
            }
        }
        void txtparolaMouseEnter()
        {
            for (int i = 0; i <= 400; i++) ;
            {
                txtyöneticipaorla.BackColor = Color.Gainsboro;
            }
        }
        void txtparolaMouseLeave()
        {
            for (int i = 0; i <= 400; i++) ;
            {
                txtyöneticipaorla.BackColor = Color.White;
            }
        }
        private void txtboxyntckullancııad_MouseEnter(object sender, EventArgs e)
        {
            txtkulanıcıadmouseent();
        }

        private void txtboxyntckullancııad_MouseLeave(object sender, EventArgs e)
        {
            txtkulanıcıadMouseleave();
        }

        private void txtyöneticipaorla_MouseEnter(object sender, EventArgs e)
        {
            txtparolaMouseEnter();
        }
        private void txtyöneticipaorla_MouseLeave(object sender, EventArgs e)
        {
            txtparolaMouseLeave();
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //Tabloya yönetici ekleme
            SqlCommand komut = new SqlCommand("insert into Admin1 (YöneticiAd,YöneticiŞifre) values (@a1,@a2)", bgl.baglantı());
            komut.Parameters.AddWithValue("@a1", txtboxyntckullancııad.Text);
            komut.Parameters.AddWithValue("@a2", txtyöneticipaorla.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Yönetici Eklendi");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet7.Admin1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.admin1TableAdapter.Fill(this.yurtKayıtSistemiDataSet7.Admin1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagrid tıklandıgında nesnelere veri taşıma
            int seçen;
            seçen = dataGridView1.SelectedCells[0].RowIndex;
            string id, şifre, ad;
            id = dataGridView1.Rows[seçen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[seçen].Cells[1].Value.ToString();
            şifre = dataGridView1.Rows[seçen].Cells[2].Value.ToString();
            textBoxyöneticiıd.Text = id;
            txtboxyntckullancııad.Text = ad;
            txtyöneticipaorla.Text = şifre;
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet7.Admin1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.admin1TableAdapter.Fill(this.yurtKayıtSistemiDataSet7.Admin1);

        }
        private void buttonsil_Click(object sender, EventArgs e)
        {
            //Yönetici kaydı silme
            SqlCommand komutsil = new SqlCommand("Delete from Admin1 where YöneticiID=@y1", bgl.baglantı());
            komutsil.Parameters.AddWithValue("@y1", textBoxyöneticiıd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Yönetici Kaydı Silindi");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet7.Admin1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.admin1TableAdapter.Fill(this.yurtKayıtSistemiDataSet7.Admin1);
            textBoxyöneticiıd.Text = "";
            txtboxyntckullancııad.Text = "";
            txtyöneticipaorla.Text = "";
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            //Yönetici bilgi güncelleme 
            SqlCommand komut = new SqlCommand("update Admin1 set YöneticiAd=@p1,YöneticiŞifre=@p2 where YöneticiID=@e3", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtboxyntckullancııad.Text);
            komut.Parameters.AddWithValue("@p2", txtyöneticipaorla.Text);
            komut.Parameters.AddWithValue("@e3", textBoxyöneticiıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Bilgiler Güncellendi");
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet7.Admin1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.admin1TableAdapter.Fill(this.yurtKayıtSistemiDataSet7.Admin1);

        }
    }
}
