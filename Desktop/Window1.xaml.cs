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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void LoginTextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = "";
            LoginTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void NewMailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            NewMailTextBox.Text = "";
            NewMailTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void DoubleNewPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            DoubleNewPasswordTextBox.Text = "";
            DoubleNewPasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void NewPasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            NewPasswordTextBox.Text = "";
            NewPasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            this.Close();
        }

        private void tpMainWindowButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            this.Close();
        }

    }
}
