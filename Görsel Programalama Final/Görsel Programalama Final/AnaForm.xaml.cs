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

namespace Görsel_Programalama_Final
{
    /// <summary>
    /// Interaction logic for AnaForm.xaml
    /// </summary>
    public partial class AnaForm : Window
    {
        public AnaForm()
        {
            InitializeComponent();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(text1.Text);
            list2.Items.Add(text2.Text);
            text1.Clear();
            text2.Clear();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Lütfen silmek istediğiniz alanı veya alanları seçin eğer seçtiyseniz Tamam butonuna basın","Masaüstü Tek Kişilik Tatil Organizasyon Uygulaması",MessageBoxButton.OK,MessageBoxImage.Warning);
            list1.Items.Remove(list1.SelectedItem);
            list2.Items.Remove(list2.SelectedItem);



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HesaplamaFormu hf = new HesaplamaFormu();
            hf.Show();
        }
    }
}
