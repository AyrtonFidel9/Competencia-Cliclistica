using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppCompetenciaCiclistica.Clases;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.ComponentModel;

namespace WpfAppCompetenciaCiclistica.Controles
{
    /// <summary>
    /// Lógica de interacción para Ciclistas.xaml
    /// </summary>
    public partial class Ciclistas : UserControl
    {
        MainWindow objVen = new MainWindow();
        public string Nombre { get; set; }
        clCiclistas[] comp = new clCiclistas[10];
        //clase1[] competidores = new clase1[10];
        int contador = 0;
        public Ciclistas( )
        {
            InitializeComponent();
        }
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtID.Focus();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtEquipo.Focus();
            }
        }

        private void txtEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtDorsal.Focus();
            }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            clCiclistas objc = new clCiclistas();
            objc.Nombre = txtNombre.Text;
            objc.Apellido = txtApellido.Text;
            objc.ID = txtID.Text;
            objc.Equipo = txtEquipo.Text;
            objc.Dorsal = txtDorsal.Text;
            objc.Pais = comboBoxPais.Text;

            
            comp[contador] = objc;
            dgCiclistas.Items.Add(objc);
            //MessageBox.Show(Nombre);
            //competidores[contador] = objc;
            
            contador++;
            //objCicli.dgCiclistas.Items.Add(objc);

        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresar.IsOpen = true;
            //IngresarCiclista objC = new IngresarCiclista();
            //var metroWindow = (Application.Current.MainWindow as MetroWindow);
            ////objC.btnRegresar.Click += new RoutedEventHandler(btnRegresar_Click); 
            //await metroWindow.ShowMetroDialogAsync(objC);
            clCiclistas objc = new clCiclistas();
            //MessageBox.Show(nom + ap + id + equipo + dorsal + pais);
            


        }
       

            
        public void recibirParametros (string nom, string ap, string id, string equipo, string dorsal, string pais)
        {
            //clase1 objc = new clase1();
            //objc.Nombre = nom;
            //objc.Apellido = ap;
            //objc.ID = id;
            //objc.Equipo = equipo;
            //objc.Dorsal = dorsal;
            //objc.Pais = pais;
            //competidores[contador] = objc;
            //contador++;
        }

        private void btnAcutaliza_Click(object sender, RoutedEventArgs e)
        {
            objVen.Competidores = comp;
            dgCiclistas.Items.Clear();
            foreach (clCiclistas indice in objVen.Competidores)
            {
                if (indice != null)
                {
                    dgCiclistas.Items.Add(indice);
                }

            }
        }
    }

    public class Ciclista
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ID { get; set; }
        public string Equipo { get; set; }

        public string Dorsal { get; set; }

        public string Pais { get; set; }
    }
}
