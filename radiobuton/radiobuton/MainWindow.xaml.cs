﻿using System;
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

namespace radiobuton
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

        private void rbmardin_Checked(object sender, RoutedEventArgs e)
        {
            lbmardin.Background = Brushes.Red;// burda üstüne tıkladığımızda kırmızı olacak 
        }

        private void rbmardin_Unchecked(object sender, RoutedEventArgs e)
        {
            lbmardin.Background = Brushes.White; // burda doğru cvp tan  gitiği zaman beyaz olacak 
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rbkucuksayi.Background = Brushes.Red;
        }

        private void rbkucuksayi_Unchecked(object sender, RoutedEventArgs e)
        {
            rbkucuksayi.Background = Brushes.White;
        }
    }
}
