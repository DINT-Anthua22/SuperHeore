using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Superheroes
{
    class SuperHeroe : INotifyPropertyChanged, IValueConverter
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
                    //NotifyPropertyChanged("Nombre");
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
                if(_vengador || _vengador==false)
                {
                    _vengador = value;
                    NotifyPropertyChanged("Vengador");
                } 
            }
            
        }

        string _foto;
        public string Foto
        {
            get { return _foto; }

            set
            {
                if(_foto!= null)
                {
                    _foto = value;
                    NotifyPropertyChanged("Foto");
                }
            }
        }

        public static SuperHeroe GetSample()
        {
            SuperHeroe heroe = new SuperHeroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (value is bool)
            {
                if ((bool)value)
                    return "Si";
                else
                    return "No";
            }

            return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
