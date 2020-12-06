using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCompetencia
{
    class ClCompetencia
    {
        private string nombrecomp;
        private string ubicacomp;
        private string descricomp;
        private int numCicli;


        public ClCompetencia(string Nom, string ubi, string descri, int numcicli)
        {
            nombrecomp = Nom;
            ubicacomp = ubi;
            descricomp = descri;
            numCicli = numcicli;

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
