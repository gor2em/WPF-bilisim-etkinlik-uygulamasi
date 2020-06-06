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
using System.Data.SqlClient;//sql için
using Microsoft.Win32;//open file dialog
using System.Data;//connectionstate için

namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class vip : Window
    {

        public vip()
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

        private void vip_uyeOl_Click(object sender, RoutedEventArgs e)
        {
        }

        dosya ds = new dosya();
        microsoft microsoft_ = new microsoft();



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {



            cmb_sirket.SelectedIndex = 0;
            for (int i = 50; i <= 3000; i += 50)
            {
                cmb_bakiye.Items.Add(i);
            }

            kayit_tarihi.Visibility = Visibility.Collapsed;
            kayit_tarihi.SelectedDate = DateTime.Now.Date;
            lbl_tarih.Content = kayit_tarihi.Text;
            //grd_sirketler.Visibility = Visibility.Collapsed;
            //lbl_gitet.Visibility = Visibility.Collapsed;
            txt_resimYolu.IsEnabled = false;
            //grd_sirketler.Visibility = Visibility.Visible;
            //lbl_gitet.Visibility = Visibility.Visible;
            Random rnd = new Random();
            int a = (Convert.ToInt32(rnd.Next(10000, 99999)));
            lbl_kod.Content = a.ToString();
            lbl_basarili.Visibility = Visibility.Collapsed;
            //txt_kod.Text = lbl_kod.Content.ToString();




        }

        private void vip_Giris_Click(object sender, RoutedEventArgs e)
        {


        }

        private void txt_kod_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lbl_kod.Content.ToString() == txt_kod.Text)
            {
                lbl_basarili.Visibility = Visibility.Visible;
                txt_kod.IsEnabled = false;
            }
            else
            {
                //grd_sirketler.Visibility = Visibility.Collapsed;
            }
        }

        private void microsoft_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void VipUyeOl_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                if (txt_adSoyad.Text != "" && txt_tel.Text != "" && txt_sehir.Text != "" && txt_tel.Text.Length == 11 && txt_resimYolu.Text != "" && txt_kod.Text != "" && txt_kod.Text == lbl_kod.Content.ToString() && cmb_sirket.SelectedIndex != -1 && cmb_bakiye.SelectedIndex != -1)
                {

                    sqlCon.Open();
                    string sorgu = "INSERT INTO vipUyeler (v_AdSoyad,v_Tel,v_Sehir,v_Etkinlik,v_Bakiye,v_Tarih,v_ResimYolu,v_Id) values('" + this.txt_adSoyad.Text + "','" + this.txt_tel.Text + "','" + this.txt_sehir.Text + "','" + this.cmb_sirket.Text + "','" + this.cmb_bakiye.Text + "','" + this.lbl_tarih.Content + "','" + this.txt_resimYolu.Text + "','" + this.txt_kod.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı. ");
                    microsoft_.Show();
                    //microsoft_.txt_bakiye.Text = cmb_bakiye.Text; microsoft_.lbl_adsoyad.Content = txt_adSoyad.Text; microsoft_.lbl_tel.Content = txt_tel.Text; microsoft_.lbl_sehir.Content = txt_sehir.Text; microsoft_.lbl_etkinlik.Content = cmb_sirket.Text; microsoft_.lbl_kayitTarihi.Content = lbl_tarih.Content; microsoft_.lbl_id.Content = lbl_kod.Content;

                    if (cmb_sirket.SelectedIndex == 0)
                    {
                        microsoft_.lbl_id_sol.Content = txt_kod.Text; microsoft_.lbl_adsoyad_adsoyad.Content = txt_adSoyad.Text; microsoft_.txt_bakiye.Text = cmb_bakiye.Text; microsoft_.lbl_adsoyad.Content = txt_adSoyad.Text; microsoft_.lbl_tel.Content = txt_tel.Text; microsoft_.lbl_sehir.Content = txt_sehir.Text; microsoft_.lbl_etkinlik.Content = cmb_sirket.Text; microsoft_.lbl_kayitTarihi.Content = lbl_tarih.Content; microsoft_.lbl_id.Content = lbl_kod.Content;
                        microsoft_.Show();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Lütfen boş alanları doldurun!");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Telefon numarası veya ID sistemde mevcut");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void resim_Yukle(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Bir resim seçin";
            op.Filter = "JPEG Files (PNG Files (*.png)|*.png|*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (op.ShowDialog() == true)
            {
                Image1.Source = new BitmapImage(new Uri(op.FileName));
                txt_resimYolu.Text = op.FileName;
                microsoft_.uyeResim.Source = new BitmapImage(new Uri(op.FileName));

            }
        }

        private void Cmb_bakiye_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Giris_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Gir_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Txt_tel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Getir_Click(object sender, RoutedEventArgs e)
        {

            txt_adSoyad.Text = "user";
            txt_tel.Text = "12345678910";
            txt_sehir.Text = "istanbul";
            txt_resimYolu.Text = "rsm";
            cmb_sirket.Text = "Microsoft";
            txt_kod.Text = lbl_kod.Content.ToString();
            cmb_bakiye.SelectedIndex = 55;
        }
    }
}
