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
        private ObservableCollection<Butla> btl = new ObservableCollection<Butla>();
        public testy()
        {
            InitializeComponent();
            this.DataContext = this;
            btl.Add(new Butla());
            btl.Add(new Butla());

            Butle.ItemsSource = btl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btl.Add(new Butla());
        }
    }
    public class Butla : INotifyPropertyChanged
    {
        private static int count = 1;
        private int id;
        private string imie;
        public Butla()
        {
            id = count;
            count++;
            imie = "Bogdana";
        }
        public int Id
        {
            get { return this.id; }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.NotifyPropertyChanged("Id");
                }
            }
        }
        public string Imie
        {
            get { return this.imie; }
            set
            {
                if (this.imie != value)
                {
                    this.imie = value;
                    this.NotifyPropertyChanged("Imie");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
