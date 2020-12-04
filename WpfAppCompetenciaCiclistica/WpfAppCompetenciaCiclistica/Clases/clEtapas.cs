using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCompetenciaCiclistica.Clases
{
    class clEtapas
    {
        public List<clCiclistas> etapa;
        public int n;
        public clEtapas(int n)
        {
            etapa = new List<clCiclistas>(n);
            this.n = n;
        }
        /*
        public void crearEtapas(List<clCiclistas.etapa> lista)
        {
            for (int y = 0; y < n; y++)//recorre las etapas creandolas
            {
                //etapa[y].crearEtapas(lista); //crea cada etapa con la lista de ciclistas cada uno con su tiempo
            }
        }*/
    }
}
