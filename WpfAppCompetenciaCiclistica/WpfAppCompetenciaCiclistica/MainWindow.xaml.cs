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
using MahApps.Metro.Controls;
using WpfAppCompetenciaCiclistica.Controles;
using WpfAppCompetenciaCiclistica.Clases;
using System.Windows.Threading;


namespace WpfAppCompetenciaCiclistica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    

        
    public partial class MainWindow : MetroWindow
    {
        clase1[] competidores = new clase1[10];
        public MainWindow()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            Reloj.Text = DateTime.Now.ToLongTimeString();
        }

        internal clase1[] Competidores { get => competidores; set => competidores = value; }

        //evento para navegar/llamar a los controles o paginas
        private void HamburgerMenuControl_ItemClick(object sender, ItemClickEventArgs args)
        {
            //se captura el tipo de imagen del induice
            HamburgerMenuGlyphItem indice = args.ClickedItem as HamburgerMenuGlyphItem;
            if(indice != null)
            {
                switch(indice.Tag.ToString())
                {
                    case "Inicio":
                        //Inicio objI = new Inicio();
                        //this.menu.Content =objI;
                        txtBTitulo.Text = "Inicio";
                        //this.menu.Content = new Uri("/Controles/Inicio.xaml", UriKind.Relative);
                        //frNavegacion.Navigate(new Uri("/Controles/Inicio.xaml", UriKind.Relative));
                        grInicio.Visibility = Visibility.Visible;
                        grCiclistas.Visibility = Visibility.Hidden;
                        grCompetencia.Visibility = Visibility.Hidden;
                        grEtapas.Visibility = Visibility.Hidden;
                        break;
                    case "Competencia":
                        txtBTitulo.Text = "Competencia";
                        //frNavegacion.Navigate(new Uri("/Controles/Competencia.xaml", UriKind.Relative));
                        grInicio.Visibility = Visibility.Hidden;
                        grCiclistas.Visibility = Visibility.Hidden;
                        grCompetencia.Visibility = Visibility.Visible;
                        grEtapas.Visibility = Visibility.Hidden;
                        break;
                    case "Etapas":
                        txtBTitulo.Text = "Etapas";
                        //frNavegacion.Navigate(new Uri("/Controles/Etapas.xaml", UriKind.Relative));
                        grCiclistas.Visibility = Visibility.Hidden;
                        grCompetencia.Visibility = Visibility.Hidden;
                        grInicio.Visibility = Visibility.Hidden;
                        grEtapas.Visibility = Visibility.Visible;
                        break;
                    case "Ciclistas":
                        txtBTitulo.Text = "Ciclistas";
                        grInicio.Visibility = Visibility.Hidden;
                        grCiclistas.Visibility = Visibility.Visible;
                        grCompetencia.Visibility = Visibility.Hidden;
                        grEtapas.Visibility = Visibility.Hidden;
                        //frNavegacion.Navigate(new Uri("/Controles/Ciclistas.xaml", UriKind.Relative));

                        break;

                }
                   
            }


        }



        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs args)
        {

        }

        private void menu_ItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs args)
        {
        }
        //-----------------------------------------CODIGO DE LAS ETAPAS----------------------------------------------

        bool eliminar = false;


        private void crearTilesEtapas(string nombre)
        {
            Tile panel = new Tile();
            panel.Content = nombre;
            panel.Width = 290;
            panel.Height = 100;
            // panel.Tag = _tag;
            panel.Margin = new Thickness(5, 20, 5, 5);
            panel.HorizontalAlignment = HorizontalAlignment.Center;
            panel.VerticalAlignment = VerticalAlignment.Center;

            panel.Click += panel_Click; //se añade el evento


            stack.Children.Add(panel);

        }

        private void btnEliminarEtapa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("activado");
            eliminar = true;
        }
        private void panel_Click(object sender, RoutedEventArgs e)
        {

            if (eliminar == true)
            {
                stack.Children.Remove((e.Source as Tile));

                eliminar = false;

            }
        }

        private void btnAgregarEtapa_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoEtapa.IsOpen = true;
        }


























        //------------------------------CODIGO DE LOS CICLISTAS----------------------------------//
        int contador = 0;
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtApellidoCiclista.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtIDCiclista.Focus();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtEquipoCiclista.Focus();
            }
        }

        private void txtEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtDorsalCiclista.Focus();
            }
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            clase1 objc = new clase1();
            objc.Nombre = txtNombreCiclista.Text;
            objc.Apellido = txtApellidoCiclista.Text;
            objc.ID = txtIDCiclista.Text;
            objc.Equipo = txtEquipoCiclista.Text;
            objc.Dorsal = txtDorsalCiclista.Text;
            objc.Pais = comboBoxPaisCiclista.Text;


            Competidores[contador] = objc;
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
           



        }

        private void btnAcutaliza_Click(object sender, RoutedEventArgs e)
        {
            dgCiclistas.Items.Clear();
            foreach (clase1 indice in Competidores)
            {
                if (indice != null)
                {
                    dgCiclistas.Items.Add(indice);
                }

            }
        }

        private void btnAgregarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoCiclistas.IsOpen = true;
        }

        private void btnAgregarCiclista_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresar.IsOpen = true;
            
        }
    }

}
