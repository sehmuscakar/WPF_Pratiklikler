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

namespace contextMenu
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

        private void mibold_Click(object sender, RoutedEventArgs e)
        {
            benimtextbox.FontWeight = FontWeights.Bold;
        }

        private void miItalic_Click(object sender, RoutedEventArgs e)
        {
            benimtextbox.FontStyle = FontStyles.Italic;
        }

        private void mibold_Checked(object sender, RoutedEventArgs e)
        {
            benimtextbox.FontWeight = FontWeights.Bold; // bu normal olması için olması lazım herhalde ?
        }

        private void mibold_Unchecked(object sender, RoutedEventArgs e)
        {
            benimtextbox.FontWeight = FontWeights.Normal;// bu normal yapar 
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) // farenin sağ ın tıklanınca bu not gelecek işte 
        {
            benimbuton.Content = "bu bıton ile ilgili özeliktir ";
        }
    }
}
