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
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Threading;


namespace WpfAppCompetenciaCiclistica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : MetroWindow
    {
        internal List<clCiclistas> listCiclistas = new List<clCiclistas>();
        internal List<Etapa> listEtapas = new List<Etapa>();
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

        #region Codigo para las ventanas
        //evento para navegar/llamar a los controles o paginas
        private void HamburgerMenuControl_ItemClick(object sender, ItemClickEventArgs args)
        {
            //se captura el tipo de imagen del induice
            HamburgerMenuGlyphItem indice = args.ClickedItem as HamburgerMenuGlyphItem;
            if (indice != null)
            {
                switch (indice.Tag.ToString())
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
        #endregion
        #region Codigo de los Ciclistas



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
            clCiclistas objc = new clCiclistas();
            objc.Nombre = txtNombreCiclista.Text;
            objc.Apellido = txtApellidoCiclista.Text;
            objc.ID = txtIDCiclista.Text;
            objc.Equipo = txtEquipoCiclista.Text;
            objc.Dorsal = txtDorsalCiclista.Text;
            objc.Pais = comboBoxPaisCiclista.Text;

            //Uso de listas

            listCiclistas.Add(objc);

            dgCiclistas.Items.Add(objc);

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
            foreach (clCiclistas indice in listCiclistas)
            {
                if (indice != null)
                {
                    dgCiclistas.Items.Add(indice);
                }

            }
        }
        #endregion

        #region Codigo de las Etapas
        //-----------------------------------------CODIGO DE LAS ETAPAS----------------------------------------------



        bool eliminar = false;
        bool modificar = false;
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
            MessageBox.Show("Pulse la etapa que desea eliminar", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            eliminar = true;
        }
        private async void btnModificarEtapa_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("listo", "Pulse la etapa que desea modificar");
            //MessageBox.Show(, "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            modificar = true;

        }
        private void panel_Click(object sender, RoutedEventArgs e)
        {
            // Recopero el nombre del panel
            char[] titulo = e.Source.ToString().ToCharArray();
            // Separo el numero de etapa
            int num = int.Parse(titulo[titulo.Length - 1].ToString());

            if (eliminar)
            {
                stack.Children.Remove(e.Source as Tile);
                var itemToRemove = listEtapas.Single(r => r.numero == num);
                listEtapas.Remove(itemToRemove);
                eliminar = false;

            }

            if (modificar)
            {
                //EnumVisual(stack);
                Etapa numetapa = listEtapas.FirstOrDefault(x => x.numero == num);

                txtKilometrosEtapa.Text = numetapa.kilometros.ToString();
                txtNumEtapa.Text = numetapa.numero.ToString();
                TextRange textRange = new TextRange(rchDescripcionEtapa.Document.ContentStart, rchDescripcionEtapa.Document.ContentEnd);
                textRange.Text = numetapa.descripcion;
                txtUbicacionEtapa.Text = numetapa.Lugar;

                this.flyIngresoEtapa.IsOpen = true;

                modificar = false;
            }
        }

        private void btnAgregarEtapa_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoEtapa.IsOpen = true;
        }
        private void btnAgregarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoCiclistas.IsOpen = true;
        }

        private void btnAgregarCiclista_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresar.IsOpen = true;

        }

        private void txtKilometrosEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.A && e.Key <= Key.Z)
            {//(e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = true;
            }
            if (e.Key == Key.Enter)
            {
                txtUbicacionEtapa.Focus();
            }
        }


        private void rchDescripcionEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnAgregarEtapa.Focus();
            }
        }

        private void btnIngresarEtapa_Click(object sender, RoutedEventArgs e)
        {
            Etapa objetapa = new Etapa();
            objetapa.kilometros = int.Parse(txtKilometrosEtapa.Text);
            objetapa.numero = int.Parse(txtNumEtapa.Text);
            TextRange range = new TextRange(rchDescripcionEtapa.Document.ContentStart, rchDescripcionEtapa.Document.ContentEnd);
            objetapa.descripcion = range.Text;
            objetapa.Lugar = txtUbicacionEtapa.Text;

            //Uso de listas 
            listEtapas.Add(objetapa);

            crearTilesEtapas("Etapa " + objetapa.numero);

            txtKilometrosEtapa.Clear();
            txtNumEtapa.Clear();
            rchDescripcionEtapa.Document.Blocks.Clear();
            txtUbicacionEtapa.Clear();

            this.flyIngresoEtapa.IsOpen = false;

        }
        #region Clase Etapa
        public class Etapa
        {
            public int kilometros { get; set; }
            public int numero { get; set; }
            public string Lugar { get; set; }
            public string descripcion { get; set; }
        }
        #endregion
        private void txtUbicacionEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtNumEtapa.Focus();
            }
        }

        private void txtNumEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                rchDescripcionEtapa.Focus();
            }
        }
        #endregion

        public void EnumVisual(Visual myVisual)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(myVisual); i++)
            {
                // Retrieve child visual at specified index value.
                Visual childVisual = (Visual)VisualTreeHelper.GetChild(myVisual, i);
                //// Do processing of the child visual object.
                try
                {
                    MessageBox.Show((childVisual as FrameworkElement).ToString());
                }catch
                {

                }
                EnumVisual(childVisual);
            }
        }



        /*
        
        
            {​​​​
            
                {​​​​
                if ((childVisual as FrameworkElement).ToString() == "System.Windows.Controls.Image")
                    {

                    }
                }​​​​catch
                {
                    //zzz

                    // Enumerate children of the child visual object.
                }​​​​
                }
        }*/
    }
    
}

/* para ordenar se crea otra lista y se guarda en ella de forma ordenada
 List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList(); 
 */


/* para hacer las busquedas
 List<string> provincies = GetProvincias();
 
string patternSearch = "na";
 
string resultFind = provinces.Find(
     delegate(string current)
     {
          return current.Contains(patternSearch);
     }
);
 */