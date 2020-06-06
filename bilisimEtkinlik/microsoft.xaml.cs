


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
using System.Media;
using Microsoft.Win32;

namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class microsoft : Window
    {
        public static System.Media.SystemSound Beep { get; }
        public microsoft()
        {
            InitializeComponent();
        }

        dosya ds = new dosya();

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rectangle_md_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();//mouse ile kaydırma işlemi
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gbox_uyeBilgileri.Visibility = Visibility.Collapsed;
            //txt_bakiye.Text = lbl_bakiye.Content.ToString();
            //int a = 5000;
            //txt_bakiye.Text = a.ToString();

            lbl_id_sol.Content = lbl_id.Content;
            lbl_adsoyad_adsoyad.Content = lbl_adsoyad.Content;
            uyeResim_sol.Source = uyeResim.Source;
            //int para = 5000;
            //txt_bakiye.Text = para.ToString();

            //sepetUrunlerim.SelectedItem = sepetim;

        }



        private void microsoft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UyeBilgileri_Click(object sender, RoutedEventArgs e)
        {
            gbox_uyeBilgileri.Visibility = Visibility.Visible;
            gbox_urunler.Visibility = Visibility.Collapsed;
            gbox_urunlerim.Visibility = Visibility.Collapsed;
            my_grid.Visibility = Visibility.Collapsed;
        }

        private void Urunler_Click(object sender, RoutedEventArgs e)
        {
            gbox_urunler.Visibility = Visibility.Visible;
            gbox_uyeBilgileri.Visibility = Visibility.Collapsed;
            gbox_urunlerim.Visibility = Visibility.Collapsed;
            my_grid.Visibility = Visibility.Collapsed;
        }




        int hak = 1;
        private void Simulasyon_Click(object sender, RoutedEventArgs e)
        {
            simulasyon sm = new simulasyon();

            if (hak == 1)
            {
                if (MessageBox.Show("Simülasyona bir kere giriş yapabilirsiniz.", "Simülasyon", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    sm.Show();
                    sm.lbl_id.Content = lbl_id.Content;
                    hak--;
                }

            }
            else
            {
                MessageBox.Show("Buraya artık giremezsiniz");
                simulasyon.IsEnabled = false;
            }

            //else if (hak < 3 && hak > 0)
            //{
            //    MessageBox.Show("Kalan giriş hakkı: " + hak);
            //    sm.Show();
            //    sm.lbl_id.Content = lbl_id.Content;
            //    sm.s1.IsEnabled = false;
            //    sm.s2.IsEnabled = false;
            //}
            //else if (hak == 0 || hak < 0)
            //{
            //    MessageBox.Show("buraya giriş hakkınız kalmadı");
            //}


            //this.Close();
        }

        dosya dosyam = new dosya();

        public int kulBakiye, top = 0;

        public int[] sepetim = { 150, 80, 190, 20, 2200,399,1999};

        OpenFileDialog op = new OpenFileDialog();
        private void Cmb_urun2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            for (int i = 0; i < sepetim.Length; i++)
            {
                if (cmb_urun2.SelectedIndex == i)
                {
                    lbl_fiyat.Content = sepetim[i].ToString();
                }
                else
                {

                }
            }
        }

        private void SepeteEkle_Click(object sender, RoutedEventArgs e)
        {
            kulBakiye = Convert.ToInt32(txt_bakiye.Text);

            if (kulBakiye == 0 || kulBakiye < 0)
            {
                MessageBox.Show("yetersiz bakiye. ");
                txt_bakiye.Text = kulBakiye.ToString();
            }

            else
            {
                for (int i = 0; i < sepetim.Length; i++)
                {
                    if (cmb_urun2.SelectedIndex == i)
                    {
                        if (kulBakiye >= sepetim[i])
                        {
                            txt_bakiye.Text = Convert.ToString(kulBakiye - sepetim[i]);
                            top = sepetim[i] + top;
                            sepetUrunlerim.Items.Add(cmb_urun2.Text);
                            sepetUrunlerimFiyat.Items.Add(sepetim[i]);
                            sepetUrunlerim1.Items.Add(sepetim[i]);
                            //MessageBox.Show("  ");

                            if (txt_bakiye.Text != "")
                            {


                                string sorgu = "UPDATE uye.dbo.vipUyeler SET  v_KalanBakiye='" + this.txt_bakiye.Text + "'WHERE v_Id='" + this.lbl_id_sol.Content + "';";
                                //(Id,adsoyad,tel,sehir,unvan,sirket)
                                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                                SqlDataReader myReader;
                                try
                                {
                                    sqlCon.Open();
                                    myReader = sqlCmd.ExecuteReader();
                                    //MessageBox.Show("Güncel Bakiye kaydedildi.");

                                    while (myReader.Read()) 
                                    {

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
                        else
                        {
                            SystemSounds.Hand.Play();
                            MessageBox.Show("yetersiz bakiye.x");
                        }
                    }
                }
            }

            gbox_sepet.Visibility = Visibility.Visible;
        }


        private void UrunAl_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                if (sepetUrunlerim.Items.Count != 0 || sepetUrunlerimFiyat.Items.Count != 0)
                {
                    for (int i = 0; i < sepetim.Length; i++)
                    {
                        if (cmb_urun2.SelectedIndex == i)
                        {
                            if (kulBakiye >= sepetim[i])
                            {
                                lbl_Toplam.Content = top.ToString();
                            }
                        }
                    }
                    sqlCon.Open();
                    for (int i = 0; i < sepetUrunlerim.Items.Count; i++)
                    {


                        string sorgu = "INSERT INTO urunler (v_Id,urunAd,urunFiyat) values(@v_Id,@urunAd,@urunFiyat)";
                        SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@v_Id", lbl_id.Content);
                        sqlCmd.Parameters.AddWithValue("@urunAd", sepetUrunlerim.Items[i]);
                        sqlCmd.Parameters.AddWithValue("@urunFiyat", sepetUrunlerimFiyat.Items[i]);
                        sqlCmd.ExecuteNonQuery();

                    }
                    sepetUrunlerim.Items.Clear();
                    sepetUrunlerimFiyat.Items.Clear();
                    MessageBox.Show("Ürün alımı başarılı.");

                }
                else
                {
                    MessageBox.Show("sepet boş");
                }

            }
            catch (Exception ex)
            {
                sepetUrunlerim.Items.Clear();
                sepetUrunlerimFiyat.Items.Clear();

                MessageBox.Show(ex.Message);


            }
            finally
            {
                sqlCon.Close();

            }
            sepetUrunlerim1.Items.Clear();


        }

        private void UrunSil_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Windows_Click(object sender, RoutedEventArgs e)
        {
            gbox_urunlerim.Visibility = Visibility.Collapsed;
            gbox_urunler.Visibility = Visibility.Collapsed;
            gbox_sepet.Visibility = Visibility.Collapsed;
            gbox_uyeBilgileri.Visibility = Visibility.Collapsed;
            my_grid.Visibility = Visibility.Collapsed;
        }

        private void SepetUrunlerim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UrunTemizle_Click(object sender, RoutedEventArgs e)
        {

            if (sepetUrunlerim.Items.Count != 0 || sepetUrunlerimFiyat.Items.Count != 0)
            {
                int topBakiye = Convert.ToInt32(txt_bakiye.Text);
                top = Convert.ToInt32(lbl_Toplam.Content);
                for (int i = 0; i < sepetUrunlerimFiyat.Items.Count; i++)
                {
                    topBakiye += Convert.ToInt32(sepetUrunlerimFiyat.Items[i]);
                    sepetUrunlerim.Items.Clear();
                }
                sepetUrunlerimFiyat.Items.Clear();
                txt_bakiye.Text = topBakiye.ToString();

                MessageBox.Show("sepet temizlendi");
            }
            else
            {
                MessageBox.Show("sepet boş");
            }

        }

        private void Sepet_Click(object sender, RoutedEventArgs e)
        {
            lbl_id1.Content = "Kullanıcı ID: " + lbl_id.Content;
            gbox_urunlerim.Visibility = Visibility.Visible;
            gbox_urunler.Visibility = Visibility.Collapsed;
            gbox_sepet.Visibility = Visibility.Collapsed;
            gbox_uyeBilgileri.Visibility = Visibility.Collapsed;

            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT vipUyeler.v_AdSoyad,urunler.v_Id,urunler.urunAd,urunler.urunFiyat FROM urunler INNER JOIN vipUyeler ON (urunler.v_Id=vipUyeler.v_Id) WHERE urunler.v_Id = '" + this.lbl_id_sol.Content + "'; ";
                //string sorgu = "SELECT vipUyeler.v_AdSoyad,urunler.v_Id,urunler.urunAd,urunler.urunFiyat FROM urunler INNER JOIN vipUyeler ON (urunler.v_Id=vipUyeler.v_Id)";

                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("urunler");
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


    }
}