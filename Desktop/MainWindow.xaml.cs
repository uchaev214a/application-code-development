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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MailTextBox.Text = "";
            MailTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = "";
            PasswordTextBox.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tpFormRegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 registrationWindow = new Window1();
            registrationWindow.ShowDialog();
        }

    }
}
