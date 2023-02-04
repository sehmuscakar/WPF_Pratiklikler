using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace login
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
        SqlConnection conet;
        SqlDataReader dr;
        SqlCommand comand;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = txtkullaniciadi.Text;
            string pasword = sifre.Text;
            conet = new SqlConnection("Data Source=DESKTOP-O9RRR03;Initial Catalog=login;Integrated Security=True");
            comand = new SqlCommand();
            conet.Open();
            comand.CommandText = "select*from login where kullaniciAdi='" + txtkullaniciadi.Text + "' and sifre='" + sifre.Text + "'";
            dr = comand.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("tebrikler");
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı ve ya şifre");
            }
            conet.Close();
        }
    }
}
