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
using Microsoft.Win32;//open file dialog
namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for ga_etkinlik.xaml
    /// </summary>
    public partial class ga_etkinlik : Window
    {
        public ga_etkinlik()
        {
            InitializeComponent();
           
        }
        dosya ds = new dosya();
        //SqlConnection baglan = new SqlConnection("Data Source=GLORY\\SQLEXPRESS;Initial Catalog=betk;Integrated Security=True");
        //private void verileriGoruntule()
        //{
        //    baglan.Open();
        //    SqlCommand komut = new SqlCommand("SELECT * FROM uyeler",baglan);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while(oku.Read())
        //    {
        //        ListViewItem ekle = new ListViewItem();
        //        ekle.Content = oku["id"].ToString();
        //        //ekle.Content = oku["uyeAdSoyad"].ToString();
        //        ekle.it
        //        lw.Items.Add(ekle);
        //    }
        //}

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }


        public string lbl_tarih;
        public string resminyolu;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
                


            my_grid.Visibility = Visibility.Collapsed;
   
     
        
        }

        private void Btn_ekle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbl_GeriDon(object sender, MouseButtonEventArgs e)
        {
          

        }



        private void uyeEkle(object sender, RoutedEventArgs e)
        {


        }

        private void btn_Sil(object sender, RoutedEventArgs e)
        {


        }

        private void Btn_guncelle_Click(object sender, RoutedEventArgs e)
        {

        }


        private void rectangle_md_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();//mouse ile kaydırma işlemi
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
  

        private void s_Glory_Click(object sender, RoutedEventArgs e)
        {

            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
            
            try
            {
                sqlCon.Open();
                string sorgu = "SELECT Id,adsoyad,tel,sehir,unvan,sirket,ekleyen,kayitTarihi FROM uyeler WHERE sirket='Glory' ";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("uyeler");
                dataAdp.Fill(dt);
                my_grid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlCon.Close();

 
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

        private void s_Gameg_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT Id,adsoyad,tel,sehir,unvan,sirket,ekleyen,kayitTarihi FROM uyeler WHERE sirket='Gameg' ";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("uyeler");
                dataAdp.Fill(dt);
                my_grid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlCon.Close();


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

        private void s_Mello_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT Id,adsoyad,tel,sehir,unvan,sirket,ekleyen,kayitTarihi FROM uyeler WHERE sirket='Mello' ";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("uyeler");
                dataAdp.Fill(dt);
                my_grid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                
                sqlCon.Close();




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

        private void s_Faggo_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT Id,adsoyad,tel,sehir,unvan,sirket,ekleyen,kayitTarihi FROM uyeler WHERE sirket='Faggo' ";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("uyeler");
                dataAdp.Fill(dt);
                my_grid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlCon.Close();


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
        
        private void my_grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Ara_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(ds.dbConnectionString);
            baglanti.Open();
            DataTable tbl = new DataTable();

            string sorgu = "SELECT*FROM uyeler WHERE adsoyad LIKE '%" + ara.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            adptr.Fill(tbl);
            baglanti.Close();
            my_grid.ItemsSource = tbl.DefaultView;
        }





        //private void uyeSil_Click(object sender, RoutedEventArgs e)
        //{
        //    SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
        //    string sorgu = "DELETE FROM  uye.dbo.uyeler WHERE Id='" +this.txt_sil.Text+ "';";
        //    SqlCommand cmdDatabase = new SqlCommand(sorgu,sqlCon);
        //    SqlDataReader myReader;
        //    try
        //    {
        //        sqlCon.Open();
        //        myReader = cmdDatabase.ExecuteReader();
        //        MessageBox.Show("Üye silindi");
        //            while(myReader.Read())
        //            {

        //            }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}



        //private void uyeGuncelle_Click(object sender, RoutedEventArgs e)
        //{




        //        if (txtg_as.Text != "" && txtg_tel.Text != "" && txtg_sehir.Text != "" && cmbg_sirket.SelectedIndex != -1 && cmbg_unvan.SelectedIndex != -1 && txtg_tel.Text.Length == 11)
        //        {


        //            string sorgu = "UPDATE uye.dbo.uyeler SET  adsoyad='" + this.txtg_as.Text + "',tel='" +  this.txtg_sehir.Text + "',unvan='" + this.cmbg_unvan.Text + "',sirket='" + this.cmbg_sirket.Text + "' WHERE tel='" + this.txtg_tel.Text + "' ;";
        //            //(Id,adsoyad,tel,sehir,unvan,sirket)
        //            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
        //            SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
        //            SqlDataReader myReader;
        //            try
        //            {
        //                  sqlCon.Open();
        //                  myReader=sqlCmd.ExecuteReader();
        //                 MessageBox.Show("Güncelleme başarılı");

        //                while(myReader.Read())
        //                {

        //                }

        //            }
        //            catch (Exception ex)
        //            {

        //                MessageBox.Show(ex.Message);

        //            }
        //            finally
        //            {
        //                sqlCon.Close();
        //            }


        //        }
        //        else
        //        {
        //            MessageBox.Show("Lütfen boş alanları doldurun!");
        //        }



        //}



    }
}
