using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
namespace bilisimEtkinlik
{

    class dosya
    {

        public string dbConnectionString = "Data Source=;Initial Catalog=uye;Integrated Security=True";
        public SqlConnection sqlCon = new SqlConnection("Data Source=GLORY\\GLORY;Initial Catalog=adminDB;Integrated Security=True");
        private SqlConnection con = new SqlConnection("Data Source=GLORY\\GLORY;Initial Catalog=uye;Integrated Security=True");

        public void YeniSatirEkle(string tc)
        {
            try
            {
                if(tc.Length==11)
                {
                    con.Open();
                    string sorgu = "INSERT INTO hizliKayit (tc) values('" + tc + "')";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, con);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı.");
                }
                else
                {
                    MessageBox.Show("TC NO 11 haneli olmalıdır.");
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bu TC veritabanında bulunmaktadır."+ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void SatiriSil(string tc)
        {
            try
            {
                con.Open();
                SqlCommand kmt = new SqlCommand("DELETE  hizliKayit WHERE tc=" + tc, con);
                kmt.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt silindi...");
            }
            catch
            {
                MessageBox.Show("Kayıt silinemedi!");
            }
            finally
            {
                con.Close();
            }

        }

        public void SatiriGuncelle(string ID, string tc)
        {

            try
            {
                con.Open();
                SqlCommand kmt = new SqlCommand("UPDATE  hizliKayit set tc='" + tc + "' WHERE Id=" + ID, con);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı...");
               
            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız!");
            }
            finally
            {
                con.Close();
            }

        }
    }


}

