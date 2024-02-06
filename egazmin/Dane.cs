using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egazmin
{
    class Dane : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public bool pocztowka;
        public bool list;
        public bool paczka;
        public bool Pocztowka
        {
            get { return pocztowka; }
            set
            {
                pocztowka = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Pocztowka)));
                }
            }
        }
        public bool List
        {
            get { return list; }
            set
            {
                list = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(List)));
                }
            }
        }
        public bool Paczka
        {
            get { return paczka; }
            set
            {
                paczka = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Paczka)));
                }
            }
        }

        public string ulica;
        public string kodPocztowy;
        public string miasto;

        public string Ulica
        {
            get { return ulica; }
            set
            {
                ulica = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Ulica)));
                }
            }
        }
        public string KodPocztowy
        {
            get { return kodPocztowy; }
            set
            {
                kodPocztowy = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(KodPocztowy)));
                }
            }
        }
        public string Miasto
        {
            get { return miasto; }
            set
            {
                miasto = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Miasto)));
                }
            }
        }
        public Dane()
        {
            this.Ulica = ulica;
            this.KodPocztowy = kodPocztowy;
            this.Miasto = miasto;
            this.List = pocztowka;
            this.Pocztowka = list;
            this.Paczka = paczka;
        }
    }
}
