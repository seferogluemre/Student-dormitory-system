using System;
using System.IO;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmnotekleme : Form
    {
        public frmnotekleme()
        {
            InitializeComponent();
        }

        private void frmnotekleme_Load(object sender, EventArgs e)
        {

        }

        private void buttonkydt_Click(object sender, EventArgs e)
        {
            //SVF ile Metin dosyası ekleme 
            saveFileDialog1.Title = "KAYIT YERİ SEÇİN"; //Başlık ismi
            saveFileDialog1.Filter = "Metin dosyası | *.txt"; //Dosya uzantı Filtreleme
            saveFileDialog1.InitialDirectory = "C:\\Users\\yunus\\OneDrive\\Masaüstü\\Ders"; //SVF dialog açıldıgında hangi dosyada başlasın
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);//Metin yazdırma
            kaydet.WriteLine(richTextBox1.Text); //Metin içerigi
            kaydet.Close();
            MessageBox.Show("Mesaj Bırakıldı");

        }
    }
}
