using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclista
{
    class clCiclista
    {

        //datos de los ciclistas

        private string nombre;
        private string apellido;
        private string iD;
        private string equipo;
        private string dorsal;
        private string pais;

        //constructor vacio
       public clCiclista()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            iD = string.Empty;
            equipo = string.Empty;
            dorsal = string.Empty;
            pais = string.Empty;
        }

        //constructor
        public clCiclista(string Nom,string Ape,string id, string Equi,string Dor, string Pa)
        {
            nombre = Nom;
            apellido = Ape;
            iD = id;
            equipo = Equi;
            dorsal = Dor;
            pais = Pa;
        }

        //los get y set

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido;}
            set { apellido = value; }
        }
        public string ID
        {
            get { return iD;}
            set { iD = value;}
        }
        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }
        public string Dorsal
        {
            get { return dorsal; }
            set { dorsal = value; }
        }
        public string Pais
        {
            get { return pais;}
            set { pais = value;}
        }

    }
}
