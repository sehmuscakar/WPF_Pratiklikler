using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf_uygulama_1
{
    /// <summary>
    /// Interaction logic for hesaplama_formu.xaml
    /// </summary>
    public partial class hesaplama_formu : Window
    {
        public hesaplama_formu()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, RoutedEventArgs e)
        {
            int kisisayisi = Convert.ToInt16(textbox2.Text);
            int ucret = Convert.ToInt16(textboxucret.Text);
            txtsonuc.Text = (kisisayisi * ucret).ToString();
        }
    }
}
