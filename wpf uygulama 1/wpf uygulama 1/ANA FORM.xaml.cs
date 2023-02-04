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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_uygulama_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kişi ve Tercih Etiği Şehir Eklenmesi için Tamam Butonuna Basın Lütfen", "EKLEME", MessageBoxButton.OK);
            liste1.Items.Add(textad.Text);
            liste2.Items.Add(textsoyad.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kişi ve Tercih Etiği Şehir Silinmesi için her iki Kutudada silmek istediğinizi veya istediklerinizi seçin. Seçtiyseniz  Tamam Butonuna basın Lütfen", "SİLME!!!", MessageBoxButton.OK);
            liste1.Items.Remove(liste1.SelectedItem);
            liste2.Items.Remove(liste2.SelectedItem);
        }

      

       
      
      

       
    }
}
