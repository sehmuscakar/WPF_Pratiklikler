using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace login2
{
    /// <summary>
    /// Interaction logic for loginekranı.xaml
    /// </summary>
    public partial class loginekranı : Window
    {
        public loginekranı()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=login;Integrated Security=True");

            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();
                string query = "select count(1) from login where username=@username and password=@password";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.CommandType = System.Data.CommandType.Text;
                komut.Parameters.AddWithValue("@username", txtusername.Text);
                komut.Parameters.AddWithValue("@password", txtpassword.Password);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow pencere = new MainWindow();
                    pencere.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("hatalı kulanıcıadı veya şifre ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}
