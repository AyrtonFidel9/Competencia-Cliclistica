using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCompetenciaCiclistica.Clases
{
    class clCompetencia
    {
        private string nombrecomp;
        private string ubicacomp;
        private string descricomp;
        private int numCicli;


        public clCompetencia(string Nom, string ubi, string descri, int numcicli)
        {
            this.nombrecomp = Nom;
            this.ubicacomp = ubi;
            this.descricomp = descri;
            this.numCicli = numcicli;

        }

        public string Nombre
        {
            get { return nombrecomp; }
            set { nombrecomp = value; }
        }

        public string Ubicacion
        {
            get { return ubicacomp; }
            set { ubicacomp = value; }
        }
        public string Descripcion
        {
            get { return descricomp; }
            set { descricomp = value; }
        }
        public int NumCiclista
        {
            get { return numCicli; }
            set { numCicli = value; }
        }
    }
}
