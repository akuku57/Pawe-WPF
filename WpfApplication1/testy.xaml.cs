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
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for testy.xaml
    /// </summary>
    public partial class testy : Window
    {
        
        public testy()
        {
            InitializeComponent();
            this.DataContext = this;
            ButleStored.btl.Add(new Butla());
            ButleStored.btl.Add(new Butla());
            //btl.Add(new Butla());
           // btl.Add(new Butla());

            Butle.ItemsSource = ButleStored.btl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButleStored.btl.Add(new Butla());
        }
    }
    
}
