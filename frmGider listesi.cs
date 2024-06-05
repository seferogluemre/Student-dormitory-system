using System;
using System.Windows.Forms;

namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmGider_listesi : Form
    {
        public frmGider_listesi()
        {
            InitializeComponent();
        }
        private void frmGider_listesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet6.Giderler1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderler1TableAdapter.Fill(this.yurtKayıtSistemiDataSet6.Giderler1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagride tıklandıgı zaman o hücredeki verileri araçlara taşıma
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            frmGiderGüncelleme fr1 = new frmGiderGüncelleme();
            fr1.giderId = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            fr1.elektrik = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            fr1.su = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            fr1.dogalgaz = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            fr1.internet = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            fr1.gıda = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            fr1.personel = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            fr1.diger = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            fr1.Show();
        }
    }
}
