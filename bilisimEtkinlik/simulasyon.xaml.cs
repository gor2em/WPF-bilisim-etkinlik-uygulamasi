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
using System.ComponentModel;
using System.Windows.Media.Animation; //doubleanimation
using System.Windows.Threading;//timer için

namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class simulasyon : Window
    {

        DispatcherTimer timer;
        int saniye = 0;

        public simulasyon()
        {
            InitializeComponent();
        }

        microsoft microsoft_ = new microsoft();
        public void timer_tick(object sender, EventArgs e)
        {
            saniye++;
            sureSay.Content = saniye.ToString();


            if (saniye == 2) { s4.Visibility = Visibility.Collapsed; }
            if (saniye == 3) { gr_salon.Visibility = Visibility.Collapsed; }
            if (saniye == 4) { gr_salonsec.Visibility = Visibility.Collapsed; }
            if (saniye == 5) { lbl_hazirlan.Visibility = Visibility.Collapsed;m_etkinlik.Visibility = Visibility.Visible; }

            if(saniye==25)
            {
                this.Close();
                
            }
        }




        private void rectangle_md_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();//mouse ile kaydırma işlemi
        }

        dosya ds = new dosya();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            gr_salon.Visibility = Visibility.Collapsed;



            //if (salonDurumu.Value == salonDurumu.Maximum)
            //{
            //    lbl_durum.Foreground = System.Windows.Media.Brushes.OrangeRed;
            //    lbl_durum.Content = "Salon dolu";
            //    salonDurumu.Foreground = System.Windows.Media.Brushes.OrangeRed;

            //}

        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void S1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(ds.dbConnectionString);
            string sorgu = "SELECT TOP 1 * FROM salon ORDER BY uyeSira DESC";
            int deger;
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            deger = (int)komut.ExecuteScalar();
            baglanti.Close();
            label1.Content = deger;
            salonDurumu.Value = Convert.ToDouble(label1.Content);
            salonDurumu.Maximum = 5;
            salonSec.IsEnabled = true;
            gr_salon.Visibility = Visibility.Visible;
            if (salonDurumu.Value == salonDurumu.Maximum)
            {
                lbl_durum.Foreground = System.Windows.Media.Brushes.OrangeRed;
                lbl_durum.Content = "Salon dolu";
                salonDurumu.Foreground = System.Windows.Media.Brushes.OrangeRed;
                salonSec.IsEnabled = false;
                MessageBox.Show("Bu salon dolu. Diğer salonu deneyiniz!");
                s1.IsEnabled = false;
                salonSec2.IsEnabled = false;
            }

        }


        private void SalonSec_Click(object sender, RoutedEventArgs e)
        {

            salonDurumu.Value = Convert.ToDouble(label1.Content);
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {


                if (salonDurumu.Value < salonDurumu.Maximum)
                {

                    sqlCon.Open();
                    salonDurumu.Value++;
                    string sorgu = "INSERT INTO salon (uyeId,uyeSira) values(@uyeId,@uyeSira)";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@uyeId", lbl_id.Content);
                    sqlCmd.Parameters.AddWithValue("@uyeSira", salonDurumu.Value);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı. ");

                    //
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromSeconds(1);
                    
                    timer.Tick += new EventHandler(timer_tick);
                    timer.Start();
                    //

                    salonSec.IsEnabled = false;
                    s2.IsEnabled = false;
                    s1.IsEnabled = false;


                }
                if (salonDurumu.Value == salonDurumu.Maximum)
                {
                    lbl_durum.Foreground = System.Windows.Media.Brushes.OrangeRed;
                    lbl_durum.Content = "Salon dolu";
                    salonDurumu.Foreground = System.Windows.Media.Brushes.OrangeRed;
                    s1.IsEnabled = false;

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

        private void S2_Click(object sender, RoutedEventArgs e)
        {


            salonSec2.IsEnabled = true;
            SqlConnection baglanti = new SqlConnection(ds.dbConnectionString);
            string sorgu = "SELECT TOP 1 *FROM salon2 ORDER BY uyeSira DESC";
            int deger;
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            deger = (int)komut.ExecuteScalar();
            baglanti.Close();
            label2.Content = deger;
            salonDurumu.Value = Convert.ToDouble(label2.Content);
            salonDurumu.Maximum = 50;

            gr_salon.Visibility = Visibility.Visible;
            if (salonDurumu.Value == salonDurumu.Maximum)
            {
                lbl_durum.Foreground = System.Windows.Media.Brushes.OrangeRed;
                lbl_durum.Content = "Salon dolu";
                salonDurumu.Foreground = System.Windows.Media.Brushes.OrangeRed;
                salonSec2.IsEnabled = false;
                MessageBox.Show("Bu salon dolu. Diğer salonu deneyiniz!");
                s2.IsEnabled = false;
                salonSec.IsEnabled = false;
            }
            else
            {
                s1.IsEnabled = false;
                lbl_durum.Foreground = System.Windows.Media.Brushes.Green;
                lbl_durum.Content = "AÇIK";
                salonDurumu.Foreground = System.Windows.Media.Brushes.Green;
            }
        }

        private void SalonSec2_Click(object sender, RoutedEventArgs e)
        {
            salonDurumu.Value = Convert.ToDouble(label2.Content);
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {


                if (salonDurumu.Value < salonDurumu.Maximum)
                {

                    sqlCon.Open();
                    salonDurumu.Value++;
                    string sorgu = "INSERT INTO salon2 (uyeId) values(@uyeId)";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@uyeId", lbl_id.Content);
                    //sqlCmd.Parameters.AddWithValue("@uyeSira", salonDurumu.Value);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı. ");
                    //
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromSeconds(1);
                    timer.Tick += new EventHandler(timer_tick);
                    timer.Start();
                    //


                    lbl_hazirlan.Visibility = Visibility.Visible;
                    s2.IsEnabled = false;
                    salonSec2.IsEnabled = false;
                    salonSec.IsEnabled = false;
                    s1.IsEnabled = false;

                }
                if (salonDurumu.Value == salonDurumu.Maximum)
                {
                    lbl_durum.Foreground = System.Windows.Media.Brushes.OrangeRed;
                    lbl_durum.Content = "Salon dolu";
                    salonDurumu.Foreground = System.Windows.Media.Brushes.OrangeRed;
                    salonSec2.IsEnabled = false;
                    s2.IsEnabled = false;
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

        private void S4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("yakında");
        }


    }


}

