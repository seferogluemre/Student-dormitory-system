using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Ogrenci_Yurt_Sistemi
{
    public partial class frmadmingiriş : Form
    {
        public frmadmingiriş()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void textBoxKullanıcıadı_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                textBoxKullanıcıadı.BackColor = Color.Gainsboro;
            }
        }

        private void textBoxKullanıcıadı_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                textBoxKullanıcıadı.BackColor = Color.White;
            }
        }

        private void textBoxparola_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                textBoxparola.BackColor = Color.Gainsboro;
            }
        }

        private void textBoxparola_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= 400; i++)
            {
                textBoxparola.BackColor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                if (checkBox1.Checked == true)
                {
                    textBoxparola.PasswordChar = '*';
                }
                else
                {
                    textBoxparola.PasswordChar = '\0';
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //veritabanlı admin girişi
            SqlCommand komutg = new SqlCommand("select * from Admin1 where YöneticiAd=@p1 and YöneticiŞifre=@p2", bgl.baglantı());
            komutg.Parameters.AddWithValue("@p1", textBoxKullanıcıadı.Text);
            komutg.Parameters.AddWithValue("@p2", textBoxparola.Text);
            SqlDataReader oku = komutg.ExecuteReader();
            if (oku.Read())
            {
                Frmanaform fr = new Frmanaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı ad veya şifre");
                textBoxKullanıcıadı.Text = "";
                textBoxparola.Text = "";
                textBoxKullanıcıadı.Focus();

            }
            bgl.baglantı().Close();
        }
    }
}
