using System;
using System.Windows.Forms;

namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmÖgrenciRapor : Form
    {
        public frmÖgrenciRapor()
        {
            InitializeComponent();
        }
        private void frmÖgrenciRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet10.Ögrenci1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ögrenci1TableAdapter.Fill(this.yurtKayıtSistemiDataSet10.Ögrenci1);
            this.reportViewer1.RefreshReport();
        }
    }
}
