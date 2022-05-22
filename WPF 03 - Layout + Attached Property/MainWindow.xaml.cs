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
        private int _round = 0;
        int randomForButton;
        int PCMovement = 0;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Reset(object sender, RoutedEventArgs click)
        {
            MainWindow newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }
            private void Button_Click(object sender, RoutedEventArgs click)
        {
            if (_round%2==0)
            {
                if (sender is Button)
                {
                    (sender as Button).IsEnabled = false;

                    (sender as Button).Content = "X";

                    _round++;
                    PCMovement = 0;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (PCMovement == 0)
                    {
                        randomForButton = random.Next(1, 9);
                        CrazyPCWithVeryEfficientScript(randomForButton);
                    }
                }
            }
                if (_round == 9)
                {
                    EndGameLabel.Visibility = Visibility.Visible;
                    GameReset.Visibility = Visibility.Visible;
                }
        }
        private void CrazyPCWithVeryEfficientScript(int randomized)
        {

            switch (randomized)
                {
                    case 1:
                        if (LewyGorny.IsEnabled == true)
                        {
                            LewyGorny.Content = "O";
                            LewyGorny.IsEnabled = false;
                            _round++;
                        PCMovement = 1;
                        break;
                    }
                    break;
                case 2:
                        if (PrawyGorny.IsEnabled == true)
                        {
                            PrawyGorny.Content = "O";
                            PrawyGorny.IsEnabled = false;
                            _round++;
                        PCMovement = 1; 
                        break;
                    }
                    break;
                case 3:
                        if (SrodkowyDolny.IsEnabled == true)
                        {
                            SrodkowyDolny.Content = "O";
                            SrodkowyDolny.IsEnabled = false;
                            _round++;
                        PCMovement = 1; break;

                    }
                    break;
                case 4:
                        if (SrodkowyGorny.IsEnabled == true)
                        {
                            SrodkowyGorny.Content = "O";
                            SrodkowyGorny.IsEnabled = false;
                            _round++; 
                        PCMovement = 1; 
                        break;

                    }
                    break;

                case 5:
                        if (LewyDolny.IsEnabled == true)
                        {
                            LewyDolny.Content = "O";
                            LewyDolny.IsEnabled = false;
                            _round++;
                        PCMovement = 1;
                        break;
                    }
                    break;

                case 6:
                        if (PrawyDolny.IsEnabled == true)
                        {
                            PrawyDolny.Content = "O";
                            PrawyDolny.IsEnabled = false;
                            _round++; PCMovement = 1; break;

                    }
                    break;
                case 7:
                        if (SrodkowySrodkowy.IsEnabled == true)
                        {
                            SrodkowySrodkowy.Content = "O";
                            SrodkowySrodkowy.IsEnabled = false;
                            _round++; PCMovement = 1;  break;

                    }
                    break;

                case 8:
                        if (SrodkowyDolny.IsEnabled == true)
                        {
                            SrodkowyDolny.Content = "O";
                            SrodkowyDolny.IsEnabled = false;
                            _round++; PCMovement = 1; break;

                    }
                    break;
                case 9:
                        if (LewySrodkowy.IsEnabled == true)
                        {
                            LewySrodkowy.Content = "O";
                            LewySrodkowy.IsEnabled = false;
                            _round++; PCMovement = 1; break;

                    }
                    break;

            }
        }

    }
}
