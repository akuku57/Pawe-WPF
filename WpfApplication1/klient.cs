using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfApplication1
{
    public class Klient : INotifyPropertyChanged
    {
        private static int count = 1;
        private int id;
        private string imie;
        public Klient()
        {
            id = count;
            count++;
            imie = "Bogdan";
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
        public override string ToString()
        {
            return string.Format("{0} ({1})", Imie, Id);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
