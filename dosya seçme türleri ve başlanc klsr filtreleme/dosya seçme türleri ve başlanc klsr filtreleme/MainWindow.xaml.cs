using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;//buda gerekli dosya işlemleri için giriş cıkış işlemleri için 
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;// bunu ekle öyle dosya işlemlerine geç 
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dosya_seçme_türleri_ve_başlanc_klsr_filtreleme
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

        private void DOSYAAÇ_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();// bu sınıf acılır 
            if (openFileDialog.ShowDialog() == true)// openFileDialog.ShowDialog() seçilen dosya açılır 
            {
                butextbox.Text = File.ReadAllText(openFileDialog.FileName);// burda da dosya okunur ve ismi text box yazılır 
            }
        }
    }
}
