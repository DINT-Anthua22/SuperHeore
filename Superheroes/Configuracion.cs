using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Configuracion : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _ajusteImagen;
        public string AjusteImagen { get { return _ajusteImagen; } 
                set {
                    if (_ajusteImagen != value)
                    {
                        _ajusteImagen = value;
                        NotifyPropertyChanged("AjusteImagen");
                    }
                }
        }

        string _fondo;
        public string Fondo { get { return _fondo; } set
            {
                if (_fondo != value)
                {
                    _fondo = value;
                    NotifyPropertyChanged("Fondo");
                }
            }
        }

        public Configuracion()
        {
        }

        public Configuracion(string fondo, string ajusteimagen)
        {
            _fondo = fondo;
            _ajusteImagen = ajusteimagen;
        }

        
    }
}
