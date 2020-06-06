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
    public partial class ana : Window
    {
        public ana()
        {
            InitializeComponent();
           
        }


        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }


        public string lbl_tarih;
        public string resminyolu;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            nou_gaetkinlik.Visibility = Visibility.Collapsed;
            nou_simulasyon.Visibility = Visibility.Collapsed;
        }

      
     

   
   
        private void rectangle_md_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();//mouse ile kaydırma işlemi
        }

        private void Vip_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("VIP bölümüne giriş yapmak üzeresiniz.", "VIP", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                vip vip_ = new vip();
                vip_.Show();
                //this.Close();
            }
            else
            {

            }
        }

        private void Anaadmin_Click(object sender, RoutedEventArgs e)
        {
            admin admin_ = new admin();
            admin_.Show();
            //this.Close();
        }

        private void Uye_Click(object sender, RoutedEventArgs e)
        {
            uye uye_ = new uye();
            uye_.Show();
            //this.Close();
        }

        private void NoUye_Click(object sender, RoutedEventArgs e)
        {
            if(noUye.IsEnabled==true)
            {
                nou_gaetkinlik.Visibility = Visibility.Visible;
                nou_simulasyon.Visibility = Visibility.Visible;
            }
            noUye.IsEnabled = false;

        }

        private void Nou_gaetkinlik_Click(object sender, RoutedEventArgs e)
        {

            panel p_ = new panel();
            p_.Show();
            //this.Close();
        }

        private void Nou_simulasyon_Click(object sender, RoutedEventArgs e)
        {
            simulasyon s_ = new simulasyon();
            s_.Show();
            Random rnd = new Random();
            int a = (Convert.ToInt32(rnd.Next(10000, 99999)));
            s_.lbl_id.Content = a.ToString();


            //this.Close();
        }
    }
}
