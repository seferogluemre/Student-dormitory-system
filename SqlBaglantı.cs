using System.Data.SqlClient;

namespace Ogrenci_Yurt_Sistemi
{
    class SqlBaglantı
    {
        public SqlConnection baglantı()
        {
            //Sql baglantıyı class ile tanımlama 
            SqlConnection baglan = new SqlConnection("Data Source=EMRE_SEFEROGLU\\SQLEXPRESS;Initial Catalog=YurtKayıtSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
