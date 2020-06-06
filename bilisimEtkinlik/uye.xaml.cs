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
using System.Text.RegularExpressions;//sayısal karakter için
using Microsoft.Win32;//open file dialog
using System.Data.SqlClient;

namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for uye.xaml
    /// </summary>
    public partial class uye : Window
    {
        public uye()
        {
            InitializeComponent();
        }
        dosya ds = new dosya();

        ga_etkinlik ga_etkinlik_ = new ga_etkinlik();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            kayit_tarihi.Visibility = Visibility.Collapsed;
            rd_e.IsChecked = true;
            kayit_tarihi.SelectedDate = DateTime.Now.Date;

        
            ga_etkinlik_.lbl_tarih=kayit_tarihi.Text;


            if(cmb_sirket.SelectedIndex==0)
            {
                ga_etkinlik_.s_Glory.Visibility = Visibility.Collapsed;
            }
        }

        private void admin(object sender, RoutedEventArgs e)
        {
            admin admin_ = new admin();
            admin_.Show();
            this.Close();
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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        

        
        

        private void Cmb_unvan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmb_sirket_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_sirket.SelectedIndex == 4)
            {
                MessageBox.Show("Yapım aşamasında");
            }
        }

        private void uyeOl_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                if (txt_adSoyad.Text != "" && txt_tel.Text != "" && txt_sehir.Text != "" && cmb_sirket.SelectedIndex != -1 && cmb_unvan.SelectedIndex != -1 && txt_tel.Text.Length == 11 && rd_e.IsChecked != null && rd_h.IsChecked != null)
                {

                    sqlCon.Open();
                    string sorgu = "INSERT INTO uyeler (adsoyad,tel,sehir,unvan,sirket,kayitTarihi) values('" + this.txt_adSoyad.Text + "','" + this.txt_tel.Text + "','" + this.txt_sehir.Text + "','" + this.cmb_unvan.Text + "','" + this.cmb_sirket.Text + "','" + this.kayit_tarihi.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                   
                    //txt_adSoyad.Clear();
                    //txt_tel.Clear();
                    //txt_sehir.Clear();
                    //cmb_sirket.Items.Clear();
                    //cmb_unvan.Items.Clear();
                    //txt_tel.Clear();
                    //txt_resimYolu.Clear();
                    
                    MessageBox.Show("Kayıt başarılı.\n Ad-Soyad: " + txt_adSoyad.Text + "\n Gidilecek etkinlik: " + cmb_sirket.Text + "\n Kayıt tarihi: " + kayit_tarihi.Text);

                    
                    

                    ga_etkinlik_.Show();
                    ga_etkinlik_.lbl_hg.Content = ": " + txt_adSoyad.Text;
                    //ga_etkinlik_.listboxyaz.Items.Add(txt_adSoyad.Text);
                    this.Close();
 
                    if (cmb_sirket.SelectedIndex == 0)
                    {
                        ga_etkinlik_.s_Gameg.IsEnabled = false;
                        ga_etkinlik_.s_Mello.IsEnabled = false;
                        ga_etkinlik_.s_Faggo.IsEnabled = false;

                        ga_etkinlik_.s_Gameg.Content = "Kilitli";
                        ga_etkinlik_.s_Mello.Content = "Kilitli";
                        ga_etkinlik_.s_Faggo.Content = "Kilitli";


                    }
                    if (cmb_sirket.SelectedIndex == 1)
                    {
                        ga_etkinlik_.s_Glory.IsEnabled = false;
                        ga_etkinlik_.s_Mello.IsEnabled = false;
                        ga_etkinlik_.s_Faggo.IsEnabled = false;

                        ga_etkinlik_.s_Glory.Content = "Kilitli";
                        ga_etkinlik_.s_Mello.Content = "Kilitli";
                        ga_etkinlik_.s_Faggo.Content = "Kilitli";

                    }
                    if (cmb_sirket.SelectedIndex == 2)
                    {
                        ga_etkinlik_.s_Gameg.IsEnabled = false;
                        ga_etkinlik_.s_Glory.IsEnabled = false;
                        ga_etkinlik_.s_Faggo.IsEnabled = false;


                        ga_etkinlik_.s_Glory.Content = "Kilitli";
                        ga_etkinlik_.s_Gameg.Content = "Kilitli";
                        ga_etkinlik_.s_Faggo.Content = "Kilitli";

                    }
                    if (cmb_sirket.SelectedIndex == 3)
                    {
                        ga_etkinlik_.s_Gameg.IsEnabled = false;
                        ga_etkinlik_.s_Mello.IsEnabled = false;
                        ga_etkinlik_.s_Glory.IsEnabled = false;


                        ga_etkinlik_.s_Glory.Content = "Kilitli";
                        ga_etkinlik_.s_Mello.Content = "Kilitli";
                        ga_etkinlik_.s_Gameg.Content = "Kilitli";

                    }
                   
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

        private void Getir_Click(object sender, RoutedEventArgs e)
        {
            txt_adSoyad.Text = "user";
            txt_tel.Text = "12345678910";
            txt_sehir.Text = "istanbul";
            cmb_sirket.Text = "Glory";
            cmb_unvan.Text = "Öğrenci";
        }
    }
}
