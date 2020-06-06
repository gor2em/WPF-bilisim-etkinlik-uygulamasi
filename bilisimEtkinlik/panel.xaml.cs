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
using System.Text.RegularExpressions;//sayısal karakter için
using Microsoft.Win32;//open file dialog
namespace bilisimEtkinlik
{
    /// <summary>
    /// Interaction logic for ga_etkinlik.xaml
    /// </summary>
    public partial class panel : Window
    {
        public panel()
        {
            InitializeComponent();
           
        }
        dosya ds = new dosya();
        void uyeGetir()
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT * FROM uyeler";
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
        void vipUyeGetir()
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT * FROM vipUyeler";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("vipUyeler");
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

        void salon1Goruntule()
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT * FROM salon";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("salon");
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
        void salon2Goruntule()
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT * FROM salon2";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("salon2");
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

         void gridGoster()
        {
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT * FROM hizliKayit";
                SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
                sqlCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("hizliKayit");
                dataAdp.Fill(dt);
                grid_hk.ItemsSource = dt.DefaultView;
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

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

        void uyeGoster()
        {
            gr_uyeler.Visibility = Visibility.Visible; gr_kisayol.Visibility = Visibility.Collapsed; gr_microsoft.Visibility = Visibility.Collapsed; gr_vipUyeler.Visibility = Visibility.Collapsed;
        }
        private void Uyeler_Click(object sender, RoutedEventArgs e)
        {
            uyeGoster();
            grid_hk.Visibility = Visibility.Collapsed;
        }
        void vipGoster()
        {
            gr_vipUyeler.Visibility = Visibility.Visible; gr_uyeler.Visibility = Visibility.Collapsed; gr_kisayol.Visibility = Visibility.Collapsed; gr_microsoft.Visibility = Visibility.Collapsed;
           
        }
        private void VipUyeler_Click(object sender, RoutedEventArgs e)
        {
            vipGoster();
            
        }

        //void microsoftGoster()
        //{
        //    gr_microsoft.Visibility = Visibility.Visible; gr_uyeler.Visibility = Visibility.Collapsed; gr_kisayol.Visibility = Visibility.Collapsed; gr_vipUyeler.Visibility = Visibility.Collapsed;

        //}
        //private void Microsoft_Click(object sender, RoutedEventArgs e)
        //{
        //    microsoftGoster();
        //    grid_hk.Visibility = Visibility.Collapsed;
        //}

        void kisaYolGoster()
        {
            gr_microsoft.Visibility = Visibility.Collapsed; gr_uyeler.Visibility = Visibility.Collapsed; gr_kisayol.Visibility = Visibility.Visible; gr_vipUyeler.Visibility = Visibility.Collapsed;
            grid_hk.Visibility = Visibility.Collapsed;
        }
        private void Kisayol_Click(object sender, RoutedEventArgs e)
        {
            kisaYolGoster();
        } 

        
        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            gr_kisayol.Visibility = Visibility.Collapsed;
            gr_microsoft.Visibility = Visibility.Collapsed;
            gr_vipUyeler.Visibility = Visibility.Collapsed;
            gr_uyeler.Visibility = Visibility.Collapsed;
        }

        
        private void Uye_goruntule_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            uyeGetir();

        }

        private void Vipuye_goruntule_Click(object sender, RoutedEventArgs e)
        {
           if(vipuye_goruntule.IsFocused==true)
            {
                ara.IsEnabled = true;
            }

            my_grid.Visibility = Visibility.Visible;
            //vipUyeGetir();
            vipUyeGetir();
        }

        private void Salon_goruntule_Click(object sender, RoutedEventArgs e)
        {

            my_grid.Visibility = Visibility.Visible;
            salon1Goruntule();
        }

        private void Urun_goruntule_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            try
            {
                sqlCon.Open();
                string sorgu = "SELECT urunler.v_Id AS ID, vipUyeler.v_AdSoyad AS AdSoyad,urunler.urunAd AS ÜrünAdı,urunler.urunFiyat AS Fiyat FROM urunler INNER JOIN vipUyeler ON (urunler.v_Id=vipUyeler.v_Id)";
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

        private void Uye_sil_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Üyeler silinecek son kararınız mı?", "Üye Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                string sorgu = "DELETE FROM  uye.dbo.uyeler";
                SqlCommand cmdDatabase = new SqlCommand(sorgu, sqlCon);
                SqlDataReader myReader;
                try
                {
                    sqlCon.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Üyeler silindi");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void Vipuyesil_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("VIP Üyeler silinecek son kararınız mı?", "VIP Üye Sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                string sorgu = "DELETE FROM  uye.dbo.vipUyeler";
                SqlCommand cmdDatabase = new SqlCommand(sorgu, sqlCon);
                SqlDataReader myReader;
                try
                {
                    sqlCon.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("VIP Üyeler silindi.");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Salon_temizle_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Salon1 temizlenecek son kararınız mı?", "Salonu Temizle", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                string sorgu = "DELETE FROM  uye.dbo.salon";
                SqlCommand cmdDatabase = new SqlCommand(sorgu, sqlCon);
                SqlDataReader myReader;
                try
                {
                    sqlCon.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Salon temizlendi");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Urun_sil_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Ürünler silinecek son kararınız mı?", "Ürün sil", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                string sorgu = "DELETE FROM  uye.dbo.urunler";
                SqlCommand cmdDatabase = new SqlCommand(sorgu, sqlCon);
                SqlDataReader myReader;
                try
                {
                    sqlCon.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Ürünler silindi");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

       
        private void Ara_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(ds.dbConnectionString);
            baglanti.Open();
            DataTable tbl = new DataTable();

            string sorgu = "SELECT*FROM vipUyeler WHERE v_AdSoyad LIKE '%" + ara.Text + "%'";
            SqlDataAdapter adptr = new SqlDataAdapter(sorgu, baglanti);
            adptr.Fill(tbl);
            baglanti.Close();
            my_grid.ItemsSource =tbl.DefaultView;

        }
        private void Salon_goruntule2_Click(object sender, RoutedEventArgs e)
        {
            my_grid.Visibility = Visibility.Visible;
            SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);

            salon2Goruntule();
        }

        private void Salon_temizle2_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Salon2 temizlenecek son kararınız mı?", "Salonu Temizle", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(ds.dbConnectionString);
                string sorgu = "DELETE FROM  uye.dbo.salon2";
                SqlCommand cmdDatabase = new SqlCommand(sorgu, sqlCon);
                SqlDataReader myReader;
                try
                {
                    sqlCon.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Salon temizlendi");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void V_UyeEkle_Click(object sender, RoutedEventArgs e)
        {
            gr_uyeEkle.Visibility=Visibility.Visible;
            gr_UyeGuncelle.Visibility = Visibility.Collapsed;
            gr_UyeSil.Visibility = Visibility.Collapsed;

        }

        private void V_UyeGuncelle_Click(object sender, RoutedEventArgs e)
        {
            gr_uyeEkle.Visibility = Visibility.Collapsed;
            gr_UyeGuncelle.Visibility = Visibility.Visible;
            gr_UyeSil.Visibility = Visibility.Collapsed;
            grid_hk.Visibility = Visibility.Visible;
            gridGoster();
        }

        private void V_UyeSil_Click(object sender, RoutedEventArgs e)
        {
            gr_uyeEkle.Visibility = Visibility.Collapsed;
            gr_UyeGuncelle.Visibility = Visibility.Collapsed;
            gr_UyeSil.Visibility = Visibility.Visible;
            grid_hk.Visibility = Visibility.Visible;
            gridGoster();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void V_HizliKayit_Click(object sender, RoutedEventArgs e)
        { 
            ds.YeniSatirEkle(txt_tc.Text);
            grid_hk.Visibility = Visibility.Visible;
            gridGoster();
        }

        private void Tc_sil_Click(object sender, RoutedEventArgs e)
        {
            ds.SatiriSil(txt_tc_sil.Text);
            gridGoster();
        }

        private void Tc_guncelle_Click(object sender, RoutedEventArgs e)
        {
            ds.SatiriGuncelle(txt_id.Text,txt_yenitc.Text);
            gridGoster();
        }












        //string dbConnectionString = "Data Source=GLORY\\SQLEXPRESS;Initial Catalog=uye;Integrated Security=True";



        //SqlConnection sqlCon = new SqlConnection(dbConnectionString);

        //try
        //{
        //    if (txt_as.Text != "" && txt_tel.Text != "" && txt_sehir.Text != "" && cmb_sirket.SelectedIndex != -1 && cmb_unvan.SelectedIndex != -1 && txt_tel.Text.Length == 11)
        //    {

        //        sqlCon.Open();
        //        string sorgu = "INSERT INTO uyeler (adsoyad,tel,sehir,unvan,sirket,ekleyen) values('" + this.txt_as.Text + "','" + this.txt_tel.Text + "','" + this.txt_sehir.Text + "','" + this.cmb_unvan.Text + "','" + this.cmb_sirket.Text + "','"+this.txt_admin.Text+"')";
        //        SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
        //        sqlCmd.ExecuteNonQuery();
        //        //txt_adSoyad.Clear();
        //        //txt_tel.Clear();
        //        //txt_sehir.Clear();
        //        //cmb_sirket.Items.Clear();
        //        //cmb_unvan.Items.Clear();
        //        //txt_tel.Clear();
        //        //txt_resimYolu.Clear();

        //        MessageBox.Show("Kayıt başarılı.");



        //        //ga_etkinlik_.btn_ekle.Visibility = Visibility.Collapsed;//hidden yer kaplar collapsed 0 genişlik yükseklik şeklinde gizler.
        //        //ga_etkinlik_.btn_sil.Visibility = Visibility.Collapsed;
        //        //ga_etkinlik_.btn_guncelle.Visibility = Visibility.Collapsed;
        //        //ga_etkinlik_.lbl_geriDon.Visibility = Visibility.Collapsed;
        //        //ga_etkinlik_.Show();
        //        //ga_etkinlik_.lbl_hg.Content = ": " + txt_adSoyad.Text;
        //        ////ga_etkinlik_.listboxyaz.Items.Add(txt_adSoyad.Text);
        //        //this.Close();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen boş alanları doldurun!");
        //    }

        //}
        //catch (Exception ex)
        //{

        //    MessageBox.Show(ex.Message);

        //}
        //finally
        //{
        //    sqlCon.Close();
        //}



        //SqlConnection sqlCon = new SqlConnection(dbConnectionString);
        //string sorgu = "DELETE FROM  uye.dbo.uyeler WHERE Id='" +this.txt_sil.Text+ "';";
        //SqlCommand cmdDatabase = new SqlCommand(sorgu,sqlCon);
        //SqlDataReader myReader;
        //try
        //{
        //    sqlCon.Open();
        //    myReader = cmdDatabase.ExecuteReader();
        //    MessageBox.Show("Üye silindi");
        //        while(myReader.Read())
        //        {

        //        }
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}






        //if (txtg_as.Text != "" && txtg_tel.Text != "" && txtg_sehir.Text != "" && cmbg_sirket.SelectedIndex != -1 && cmbg_unvan.SelectedIndex != -1 && txtg_tel.Text.Length == 11)
        //{


        //    string sorgu = "UPDATE uye.dbo.uyeler SET  adsoyad='" + this.txtg_as.Text + "',tel='" +  this.txtg_sehir.Text + "',unvan='" + this.cmbg_unvan.Text + "',sirket='" + this.cmbg_sirket.Text + "' WHERE tel='" + this.txtg_tel.Text + "' ;";
        //    //(Id,adsoyad,tel,sehir,unvan,sirket)
        //    SqlConnection sqlCon = new SqlConnection(dbConnectionString);
        //    SqlCommand sqlCmd = new SqlCommand(sorgu, sqlCon);
        //    SqlDataReader myReader;
        //    try
        //    {
        //          sqlCon.Open();
        //          myReader=sqlCmd.ExecuteReader();
        //         MessageBox.Show("Güncelleme başarılı");

        //        while(myReader.Read())
        //        {

        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }
        //    finally
        //    {
        //        sqlCon.Close();
        //    }


        //}
        //else
        //{
        //    MessageBox.Show("Lütfen boş alanları doldurun!");
        //}




    }
}
