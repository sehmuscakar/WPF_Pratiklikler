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

namespace textblock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mytextblock.Text = "Hello From the cs sidel";

            TextBlock mytb = new TextBlock(); // burdan da textblock oluşturabilirsin ,ama bu varken diğer textblock lar gürünmeme ihtimali var 
            mytb.Text = "Hello şehmus";
            mytb.Inlines.Add(" ben batmanlıyım "); // buda ekleme yapar 
            mytb.TextWrapping = TextWrapping.Wrap;// buda satırlara sığmayanları aşahı yazar 
            mytb.Foreground = Brushes.Red;// buda yazıyı rengini değiştirir

            mytb.Inlines.Add(new Run("bu yazdıklarım farklı gürünecektirler renkleri yani sadece bu kod bloğun içine yazdıklarım  ")
            {
                Foreground=Brushes.Blue,
                TextDecorations = TextDecorations.Underline

            });
            this.Content = mytb;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);// bu kodu yazarsan bağlantı yazdığın adrese ancak gidebilirsin 
        }
    }
}
