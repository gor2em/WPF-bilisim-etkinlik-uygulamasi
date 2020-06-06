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
using System.Data.SqlClient;//sql için
using System.Data;//connectionstate için

namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Window
    {
       
        public admin()
        {
            InitializeComponent();
        }

        dosya ds = new dosya();
        ana an = new ana();
        int hak = 3;
        private void adminGiris(object sender, RoutedEventArgs e)
        {
            try
            {
                if(ds.sqlCon.State==ConnectionState.Closed)
                    ds.sqlCon.Open();
                string sorgu = "SELECT COUNT(1) FROM tblAdmin WHERE kulad=@kulad AND parola=@parola";
                SqlCommand sqlCmd = new SqlCommand(sorgu,ds.sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@kulad",txt_kulad.Text);
                sqlCmd.Parameters.AddWithValue("@parola", txt_parola.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if(count==1)
                {
                    MessageBox.Show("Giriş Başarılı");
                    panel panel_ = new panel();
                    panel_.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı!\n Kalan deneme hakkı "+hak);
                    if(hak==0)
                    {
                        an.anaadmin.IsEnabled = false;
                        an.Show();
                        this.Close();
                    }
                    hak--;
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                ds.sqlCon.Close();
            }
            


        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rectangle_md_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();//mouse ile kaydırma işlemi
        }
    }
}
