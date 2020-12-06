using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCompetenciaCiclistica.Clases
{
    public class ClassEmulador
    {
        //Antigua clase
        /*public class cCiclista
        {
            private string nombre;
            private string apellido;
            private string iD;
            private string equipo;
            private string dorsal;
            private string pais;

            public cCiclista(string nombre, string apellido, string iD, string equipo, string dorsal, string pais)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.iD = iD;
                this.equipo = equipo;
                this.dorsal = dorsal;
                this.pais = pais;
            }

            public string getNombre() { return nombre; }
            public string getApellido() { return apellido; }
            public string getEquipo() { return equipo; }
            public string getNumero() { return dorsal; }
        }*/
        //Nueva clase
        public class cNewCiclista
        {
            private string nombre;
            private string apellido;
            private string equipo;
            private string numero;
            private int hora;
            private int minuto;
            private int segundo;

            public cNewCiclista() { }

            public cNewCiclista(string nombre, string apellido, string equipo, string numero, int hora, int min, int seg)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.equipo = equipo;
                this.numero = numero;
                this.hora = hora;
                this.minuto = min;
                this.segundo = seg;
            }
            public string getNombre() { return nombre; }
            public string getApellido() { return apellido; }
            public string getEquipo() { return equipo; }
            public string getNumero() { return numero; }
            public int getHora() { return hora; }
            public int getMinuto() { return minuto; }
            public int getSegundo() { return segundo; }
        }



        //Creacion de listas antiguas
        public List<clCiclistas> listaC = new List<clCiclistas>();//--
        //Creacion de listas news
        public List<cNewCiclista> listaCn = new List<cNewCiclista>();//--


        //Guardar listas externas en listas internas Antiguas  metodo para pasar la lista
        public void addNewListaCiclista(List<clCiclistas> lista)
        {
            listaC = lista;
        }//++

        //crear objeto para lista
        public cNewCiclista crearObjetaListaCn(clCiclistas obj, int hora, int min, int seg)
        {
            cNewCiclista newObj = new cNewCiclista(obj.Nombre, obj.Apellido, obj.Equipo, obj.Dorsal, hora, min, seg);
            return newObj;
        }//--



        //Transformar objeto antiguo a nuevo y agregar a lista de competencia
        public void obtenerListaCn()
        {
            Random r = new Random();
            int n = listaC.Count;
            for (int i = 0; i < n; i++)
            {
                int h = r.Next(8, 13);
                int m = r.Next(0, 61);
                int s = r.Next(0, 61);
                listaCn.Add(crearObjetaListaCn(listaC[i], h, m, s));
            }
        }//++

        public void crearListaEtapas(List<clCiclistas> lista)
        {
            addNewListaCiclista(lista);
            obtenerListaCn();
        }

        public void ordenarLista()
        {
            cNewCiclista objAux;
            int hsi, msi, si;
            int hsj, msj, sj;
            for(int i = 0; i < listaCn.Count; i++)
            {
                for(int j = 1; j < listaCn.Count; j++)
                {
                    if (listaCn.Count != 1)
                    {
                        hsi = listaCn[i].getHora() * 3600;
                        msi = listaCn[i].getMinuto() * 60;
                        si = hsi + msi + listaCn[i].getSegundo();

                        hsj = listaCn[j].getHora() * 3600;
                        msj = listaCn[j].getMinuto() * 60;
                        sj = hsj + msj + listaCn[j].getSegundo();
                        if (si > sj)
                        {
                            objAux = listaCn[j];
                            listaCn[j] = listaCn[i];
                            listaCn[i] = objAux;

                        }

                    }
                }
            }
            
        }

    }

    public class cListaEtapas
    {
        public List<ClassEmulador> etapa;
        public int n;
        public cListaEtapas(int n)
        {
            etapa = new List<ClassEmulador>(n);
            this.n = n;
        }

        public void crearEtapas(List<clCiclistas> lista)
        {

            for (int y = 1; y <= n; y++)//recorre las etapas creandolas
            {
                ClassEmulador obj = new ClassEmulador();
                obj.crearListaEtapas(lista);
                etapa.Add(obj);
                
            }
        }

        public string sumarTiempo(int indice, List<clCiclistas> lista)//tiene que recorrer en un for() desde afuera en el form. El indice es el ciclista
        {
            int hora = 0;
            int minuto = 0;
            int segundo = 0;
            string s;

            for (int i = 0; i < n; i++)//recorre la lista de ciclistas para encontrar el tiempo, cada etapa es una i, el indice es el ciclista
            {
                hora += etapa[i].listaCn[indice].getHora();
                minuto += etapa[i].listaCn[indice].getMinuto();
                segundo += etapa[i].listaCn[indice].getSegundo();
            }

            s = hora + " : " + minuto + " : " + segundo;
            return s; //devuelve el tiempo como un string 
        }



    }
}
