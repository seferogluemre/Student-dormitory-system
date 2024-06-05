using System;
using System.Windows.Forms;

namespace Ogrenci_Yurt_Sistemi
{
    public partial class FrmÖgrliste : Form
    {
        public FrmÖgrliste()
        {
            InitializeComponent();
        }
        private void FrmÖgrliste_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet5.Ögrenci1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ögrenci1TableAdapter.Fill(this.yurtKayıtSistemiDataSet5.Ögrenci1);
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmÖgrdüzenle fr = new frmÖgrdüzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.Tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.Ögrtel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogmtrh = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.ögrbölüm = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odaNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliAD = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
