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
    /// Interaction logic for generujbutle.xaml
    /// </summary>
    public partial class generujbutle : Window
    {
        public generujbutle()
        {
            InitializeComponent();
            this.blok.Text = Butla.GetCount().ToString();
            foreach(Klient kl in klienciStored.kls)
            {
                combo.Items.Add(kl);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // this.combo.SelectedItem
            Butla b = new Butla((Klient)combo.SelectedItem);
            ButleStored.btl.Add(b);
        }
    }
}
