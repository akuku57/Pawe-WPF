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
using System.Security.Cryptography;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for logowanie.xaml
    /// </summary>
    public partial class logowanie : Window
    {
        public logowanie()
        {
            InitializeComponent();
            login.Padding = new Thickness(0, 3, 0, 0);
            password.Padding = new Thickness(0, 3, 0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Przyklad logowania
            if (login.Text == "Zbyszek" && password.Password == "qwerty")
            {
                //MainWindow mn = new MainWindow();
                //mn.Title = "Zarządzaj!";
                //mn.Show();
                testy tt = new testy();
                tt.Title = "Zarządzaj";
                tt.Show();
                this.Close();
            }
            else
            {
                login.Background = Brushes.RosyBrown;
                login.BorderThickness = new Thickness(4.0);
                login.BorderBrush = Brushes.Yellow;
                password.BorderThickness = new Thickness(4.0);
                password.Background = Brushes.RosyBrown;
                password.BorderBrush = Brushes.Yellow;
                alert.Foreground = Brushes.Red;
                alert.Content = "Niewłaściwy login lub hasło!";
                /*
                 * 
                 * TUTEJ HASZOWANIE TESTOWALEM
                 * 
                 * MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(test.Text));
                byte[] result = md5.Hash;
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits
                    //for each byte
                    strBuilder.Append(result[i].ToString("x2"));
                }
                test.Text = strBuilder.ToString();
                */
            }
        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            login.Background = Brushes.White;
            password.Background = Brushes.White;
            login.Padding = new Thickness(0, 0, 0, 0);
            password.Padding = new Thickness(0, 0, 0, 0);
        }

    }
}
