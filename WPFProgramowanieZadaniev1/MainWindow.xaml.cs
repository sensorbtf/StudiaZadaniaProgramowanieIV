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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //label_content.Content = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs click)
        {
            //int counter = Convert.ToInt32(label_content.Content);
            //counter++;
            //label_content.Content = counter;
        }
        private void Button_Click_1(object sender, RoutedEventArgs click)
        {
            ImageButton.Content = "Test";
        }
    }
}
