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
    public partial class vip_kayit : Window
    {
        private System.Data.ConnectionState ConnectionState;
        public vip_kayit()
        {
            InitializeComponent();
        }

        private void adminGiris(object sender, RoutedEventArgs e)
        {


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
        string dbConnectionString = "Data Source=GLORY\\SQLEXPRESS;Initial Catalog=uye;Integrated Security=True";
        private void vip_uyeOl_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(dbConnectionString);

            try
            {
                if (txt_kulad.Text != "" && cmb_sirketler.SelectedIndex != -1)
                {

                    sqlCon.Open();
                    string sorgu = "INSERT INTO vipUyeler (kulAd,kulSirket,girisKodu) values('" + this.txt_kulad.Text + "','" + this.cmb_sirketler.Text + "','"+this.txt_kod.Text+"')";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                    MessageBox.Show("Kayıt başarılı. \n Etkinliğe giriş kodunuz: "+txt_kod.Text);
                    txt_kulad.Visibility = Visibility.Collapsed;
                    cmb_sirketler.Visibility = Visibility.Collapsed;
                    txt_kod.Visibility=Visibility.Collapsed;
                    lbl_kod.Visibility = Visibility.Collapsed;
                    lbl_kulad.Visibility = Visibility.Collapsed;
                    lbl_sirketler.Visibility = Visibility.Collapsed;
                    vip_uyeOl.Visibility = Visibility.Collapsed;

                    txt_kodGir.Visibility = Visibility.Visible;
                    lbl_kodGir.Visibility = Visibility.Visible;

                }
                else
                {
                    MessageBox.Show("Lütfen boş alanları doldurun!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_kodGir.Visibility = Visibility.Collapsed;
            txt_kodGir.Visibility = Visibility.Collapsed;
            Random rnd = new Random();

            int a = (Convert.ToInt32(rnd.Next(10000, 99999)));
            txt_kod.Text = a.ToString();
        }

        private void vip_Giris_Click(object sender, RoutedEventArgs e)
        {
            txt_kulad.Visibility = Visibility.Collapsed;
            cmb_sirketler.Visibility = Visibility.Collapsed;
            txt_kod.Visibility = Visibility.Collapsed;
            lbl_kod.Visibility = Visibility.Collapsed;
            lbl_kulad.Visibility = Visibility.Collapsed;
            lbl_sirketler.Visibility = Visibility.Collapsed;
            vip_uyeOl.Visibility = Visibility.Collapsed;

            lbl_kodGir.Visibility = Visibility.Visible;
            txt_kodGir.Visibility = Visibility.Visible;


            SqlConnection sqlCon = new SqlConnection("Data Source=GLORY\\SQLEXPRESS;Initial Catalog=uye;Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string sorgu = "SELECT COUNT(1) FROM vipUyeler WHERE girisKodu=@girisKodu";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@girisKodu", txt_kodGir.Text);
                
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Giriş Başarılı");
                    ga_etkinlik ga_etkinlik_ = new ga_etkinlik();
                    ga_etkinlik_.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Kodu");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
            
        }


    }
}
