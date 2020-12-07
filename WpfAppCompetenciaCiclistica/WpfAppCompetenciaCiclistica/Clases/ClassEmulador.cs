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
            private string dorsal;
            
            Random  r = new Random();

            private int hora;
            private int minuto ;
            private int segundo;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Equipo { get => equipo; set => equipo = value; }
            public string Dorsal { get => dorsal; set => dorsal = value; }
            public string Tiempo { get => tiempo; set => tiempo = value; }

            public cNewCiclista() { }

            public cNewCiclista(string nombre, string apellido, string equipo, string numero, int hora, int min, int seg)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Equipo = equipo;
                this.dorsal = numero;
                this.hora = r.Next(1,8);
                this.minuto = r.Next(0, 61);
                this.segundo = r.Next(0, 61);
                this.tiempo = hora + ":" + minuto + ":" + segundo;
            }
            

            
            public int Hora() { return hora; }
            public int Minuto() { return minuto; }
            public int Segundo() { return segundo; }
            public void sSegundo(int val) { segundo = segundo - val; }
            private string tiempo;

            
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


        int BonificacionPrimera = 15;
        int BonificacionSegunda = 10;
        int BonificacionTercera = 5;
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
            ordenarLista();
            listaCn[0].sSegundo(BonificacionPrimera);
            listaCn[1].sSegundo(BonificacionSegunda);
            listaCn[2].sSegundo(BonificacionTercera);

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
                        hsi = listaCn[i].Hora() * 3600;
                        msi = listaCn[i].Minuto() * 60;
                        si = hsi + msi + listaCn[i].Segundo();

                        hsj = listaCn[j].Hora() * 3600;
                        msj = listaCn[j].Minuto() * 60;
                        sj = hsj + msj + listaCn[j].Segundo();
                        if (si < sj)
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
        private int n;

        public int N { get => n; set => n = value; }

        public cListaEtapas(int n)
        {
            etapa = new List<ClassEmulador>(n);
            this.N = n;
        }
        public cListaEtapas() { }

        public void crearEtapas(List<clCiclistas> lista)
        {

            for (int y = 1; y <= N; y++)//recorre las etapas creandolas
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

            for (int i = 0; i < N; i++)//recorre la lista de ciclistas para encontrar el tiempo, cada etapa es una i, el indice es el ciclista
            {
                //hora += etapa[i].listaCn[indice].Hora();
                //minuto += etapa[i].listaCn[indice].Minuto();
                //segundo += etapa[i].listaCn[indice].Segundo();
            }

            s = hora + " : " + minuto + " : " + segundo;
            return s; //devuelve el tiempo como un string 
        }



    }
}
