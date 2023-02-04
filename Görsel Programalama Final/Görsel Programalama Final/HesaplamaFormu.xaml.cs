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
    /// Interaction logic for HesaplamaFormu.xaml
    /// </summary>
    public partial class HesaplamaFormu : Window
    {
        public HesaplamaFormu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int toplamkm = Convert.ToInt16(txtkm.Text);
            int toplamkonaklamagun = Convert.ToInt16(txtkonaklamagun.Text);
            txttoplamsonuc.Text = (((toplamkm * 2*1)  + (toplamkonaklamagun * 225)).ToString()+" TL ");
        }
    }
}
