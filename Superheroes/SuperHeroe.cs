using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Superheroes
{
    class SuperHeroe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { 
                if (_nombre != value) 
                { 
                    _nombre = value; 
                    NotifyPropertyChanged("Nombre");
                } 
            }
            
        }

       


        string _enemigo;
        public string Enemigo
        {
            get { return _enemigo; }
            set
            {
                if (_enemigo != value)
                {
                    _enemigo = value; NotifyPropertyChanged("Enemigo");
                }
            }
        }

        bool _vengador;

        public bool Vengador 
        {
            get { return _vengador; }
            set { 
                   _vengador = value;
                    NotifyPropertyChanged("Vengador");
                
            }
            
        }

        string _otrafoto;
        public string Otrafoto
        {
            get { return _otrafoto; }
            set
            {
                if (_otrafoto != value)
                {
                    _otrafoto = value; NotifyPropertyChanged("Otrafoto");
                }
            }
        }

        

        public static SuperHeroe GetSample()
        {
            SuperHeroe heroe = new SuperHeroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Otrafoto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }

       
    }
}
