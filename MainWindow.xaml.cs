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

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setNameButton.IsEnabled = false;
            retNameButton.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(inputUsernameTextBox.Text);
                sw.Close();
                retNameButton.IsEnabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("username.txt");
                welcomeLabel.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void inputUsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (inputUsernameTextBox.Text != "")
            {
                setNameButton.IsEnabled = true;
            }
            else
            {
                setNameButton.IsEnabled = false;
            }
        }

        private void showDateTimeButton_Click(object sender, RoutedEventArgs e)
        {
            dateTimeTextBox.Text = DateTime.Now.ToString();
        }
    }
}
