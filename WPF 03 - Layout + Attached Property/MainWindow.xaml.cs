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

namespace WPF_03___Layout___Attached_Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _round = 1;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs click)
        {
            if (_round %)
            {
                if (sender is Button)
                {
                    (sender as Button).IsEnabled = false;

                    (sender as Button).Content = "X";

                    _round++;
                }
            }
            else
            {
                (sender as Button).Content = "O";

                (sender as Button).IsEnabled = false;

                _round++;
            }
            if (_round == 10)
            {
                Center.Visibility = Visibility.Visible;
            }
        }

    }
}
