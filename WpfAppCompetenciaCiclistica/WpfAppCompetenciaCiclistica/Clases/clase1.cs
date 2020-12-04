using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;
using System.ComponentModel;

namespace WpfAppCompetenciaCiclistica.Clases
{
    class clase1: INotifyPropertyChanged
    {
        //datos de los ciclistas

        private string nombre;
        private string apellido;
        private string iD;
        private string equipo;
        private string dorsal;
        private string pais;
        private float tiempo;

        //constructor vacio
        public clase1()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            iD = string.Empty;
            equipo = string.Empty;
            dorsal = string.Empty;
            pais = string.Empty;
        }

        //constructor
        public clase1(string Nom, string Ape, string id, string Equi, string Dor, string Pa)
        {
            this.nombre = Nom;
            this.apellido = Ape;
            this.iD = id;
            this.equipo = Equi;
            this.dorsal = Dor;
            this.pais = Pa;
        }

        //los get y set

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre");
            }
            
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("Apellido");
            }
        }
        public string ID
        {
            get { return iD; }
            set { iD = value;
                OnPropertyChanged("ID");
            }
        }
        public string Equipo
        {
            get { return equipo; }
            set { equipo = value;
                OnPropertyChanged("Equipo");
            }
        }
        public string Dorsal
        {
            get { return dorsal; }
            set { dorsal = value;
                OnPropertyChanged("Dorsal");
            }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value;
                OnPropertyChanged("Pais");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
