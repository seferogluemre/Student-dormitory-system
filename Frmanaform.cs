using System;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class Frmanaform : Form
    {
        public Frmanaform()
        {
            InitializeComponent();
        }
        private void Frmanaform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayıtSistemiDataSet3.Ögrenci1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ögrenci1TableAdapter.Fill(this.yurtKayıtSistemiDataSet3.Ögrenci1);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void rADYO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = " https://babaradyo.turkhosted.com/best/bestfm.stream/playlist.m3u8";
            }
        }
        private void rADYO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = "https://trkvz-radyolar.ercdn.net/ahaberradyo/playlist.m3u8";
            }
        }
        private void öGRENCİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }
        private void öGRENCİLİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmÖgrliste fr2 = new FrmÖgrliste();
            fr2.Show();
        }
        private void öGRENCİGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmÖgrliste fr = new FrmÖgrliste();
            fr.Show();
        }
        private void bÖLÜMEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBölümler fr4 = new FrmBölümler();
            fr4.Show();
        }
        private void bÖLÜMDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBölümler fr4 = new FrmBölümler();
            fr4.Show();
        }

        private void öDEMEALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖdemeler fr5 = new frmÖdemeler();
            fr5.Show();
        }

        private void gİDEREKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGİderler frg = new frmGİderler();
            frg.Show();

        }
        private void gİDERLİSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGider_listesi gdr = new frmGider_listesi();
            gdr.Show();
        }
        private void gELİRİSTATİSTİKLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeliristatistik fr = new frmGeliristatistik();
            fr.Show();
        }
        private void şİFREİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm fr = new frm();
            fr.Show();
        }
        private void pERSONELDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpersonel fr = new frmpersonel();
            fr.Show();
        }
        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tepki = new DialogResult();
            tepki = MessageBox.Show("Çıkış Yapıyorsunu", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tepki == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                Frmanaform fr = new Frmanaform();
                fr.ShowDialog();
            }
        }
        private void nOTEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnotekleme fr2 = new frmnotekleme();
            fr2.Show();
        }

        private void öGRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖgrenciRapor fr = new frmÖgrenciRapor();
            fr.Show();
        }
        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU PROGRAM 24.02.2024 SAAT 04.15 TARİHİNDE EMRE SEFEROGLU TARAFINDAN TAMAMLANMIŞTIR...", "ÖGRENCİ YURT OTOMASYONU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
