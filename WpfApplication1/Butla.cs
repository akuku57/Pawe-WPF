using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfApplication1
{
    public class Butla : INotifyPropertyChanged
    {
        private static int count = 5495;
        private int id;
        private Klient kl;
        public Butla()
        {
            id = count;
            count++;
            kl = new Klient();
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
        public int IdKlienta
        {
            get { return this.kl.Id; }
        }
        public string ImieKlienta
        {
            get { return this.kl.Imie; }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
