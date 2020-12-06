﻿using System;
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
using System.ComponentModel;
using System.Threading;



namespace WpfAppCompetenciaCiclistica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : MetroWindow
    {
        #region Listas y variables del programa
        internal List<clCiclistas> listCiclistas = new List<clCiclistas>();
        internal List<Etapa> listEtapas = new List<Etapa>();

        List<clCompetencia> listaCompetencia = new List<clCompetencia>();
        Tile PanelModificar = new Tile();
        string NombreCompetencia;
        #endregion

        #region Funcion Principal
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
        #endregion

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

        #region Codigo para la competencia

        string ubicomp, descripcion;
        int numCicli;

        private void txtNombreCompetencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtUbicacionCompetencia.Focus();
            }
        }

        private void txtUbicacionCompetencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                rchDescripcionCompetencia.Focus();
            }
        }

        private void limpiarFormCompetencia()
        {
            txtNombreCompetencia.Clear();
            txtUbicacionCompetencia.Clear();
            rchDescripcionCompetencia.Document.Blocks.Clear();
            txtNumCorredoresCompetencia.Clear();
        }

        private async void btnIngresarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChangedCompetencia;

            worker.RunWorkerAsync();


            

        }
        private async void worker_ProgressChangedCompetencia(object sender, ProgressChangedEventArgs e)
        {
            estadoCompetencia.Value = e.ProgressPercentage;
            if (estadoCompetencia.Value == 100)
            {
                NombreCompetencia = txtNombreCompetencia.Text;
                ubicomp = txtUbicacionCompetencia.Text;
                TextRange textRange = new TextRange(rchDescripcionCompetencia.Document.ContentStart, rchDescripcionCompetencia.Document.ContentEnd);
                descripcion = textRange.Text;
                numCicli = int.Parse(txtNumCorredoresCompetencia.Text);
                clCompetencia ciclista1 = new clCompetencia(NombreCompetencia, NombreCompetencia, descripcion, numCicli);
                listaCompetencia.Add(ciclista1);
                txtBTituloComp.Text = NombreCompetencia;

                await this.ShowMessageAsync("¡Perfecto!", "Datos ingresados correctamente");
                this.flyIngresoCompetencia.IsOpen = false;
                limpiarFormCompetencia();

                statusCiclista.Value = 0;
            }
        }

        private async void btnEliminarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            if (listaCompetencia.Count != 0)
            {
                await this.ShowMessageAsync("¡Atención!", "Competencia " + NombreCompetencia + " ha sido eliminada.");
                clCompetencia competencia = listaCompetencia.FirstOrDefault(x => x.Nombre == NombreCompetencia);
                txtBTituloComp.Text = "(Inserte el nombre de una competencia)";
                NombreCompetencia = string.Empty;
                ubicomp = string.Empty;
                descripcion = string.Empty;
                numCicli = 0;
                listaCompetencia.Remove(competencia);
            }
            else
                await this.ShowMessageAsync("¡Atención!", "No se ha ingresado ninguna competencia. Ingrese una, por favor.");



        }

        private async void btnModificarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            if (listaCompetencia.Count != 0)
            {
                await this.ShowMessageAsync("¡Atención!", "Se modificarán los datos de la competencia");
                clCompetencia competencia = listaCompetencia.FirstOrDefault(x => x.Nombre == NombreCompetencia);
                txtNombreCompetencia.Text = competencia.Nombre;
                txtUbicacionCompetencia.Text = competencia.Ubicacion;
                TextRange textRange = new TextRange(rchDescripcionCompetencia.Document.ContentStart, rchDescripcionCompetencia.Document.ContentEnd);
                textRange.Text = competencia.Descripcion;
                txtNumCorredoresCompetencia.Text = competencia.NumCiclista.ToString();
                listaCompetencia.Remove(competencia);
                this.flyIngresoCompetencia.IsOpen = true;
            }
            else
                await this.ShowMessageAsync("¡Atención!", "No se ha ingresado ninguna competencia. Ingrese una, por favor.");
        }

        private void btnAgregarCompetencia_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoCompetencia.IsOpen = true;
        }

        #endregion



        #region Codigo de los Ciclistas



        //------------------------------CODIGO DE LOS CICLISTAS----------------------------------//
        //int contador = 0;
        bool modciclista;
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

        clCiclistas objc = new clCiclistas();
        private void btnIngresarCiclista_Click(object sender, RoutedEventArgs e)
        {

            objc.Nombre = txtNombreCiclista.Text;
            objc.Apellido = txtApellidoCiclista.Text;
            objc.ID = txtIDCiclista.Text;
            objc.Equipo = txtEquipoCiclista.Text;
            objc.Dorsal = txtDorsalCiclista.Text;
            objc.Pais = comboBoxPaisCiclista.Text;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChangedCiclista;

            worker.RunWorkerAsync();

            //if (modciclista)
            //{
            //    if(statusCiclista.Value == 100)
            //    {
            //        dgCiclistas.Items.Clear();
            //        dgCiclistas.Items.Add(objc);
            //        listCiclistas.Add(objc);
            //        modciclista = false;
            //    }

            //}
            //else
            //{
            //    if (statusCiclista.Value == 100)
            //    {
            //        //Uso de listas
            //        listCiclistas.Add(objc);
            //        dgCiclistas.Items.Add(objc);
            //    }

            //}
        }

        void worker_ProgressChangedCiclista(object sender, ProgressChangedEventArgs e)
        {
            statusCiclista.Value = e.ProgressPercentage;
            if (statusCiclista.Value == 100)
            {

                txtNombreCiclista.Clear();
                txtApellidoCiclista.Clear();
                txtIDCiclista.Clear();
                txtEquipoCiclista.Clear();
                txtDorsalCiclista.Clear();
                this.flyIngresarCiclistas.IsOpen = false;
                if (modciclista)
                {
                    dgCiclistas.Items.Clear();
                    dgCiclistas.Items.Add(objc);
                    listCiclistas.Add(objc);
                    modciclista = false;

                }
                else
                {
                    //Uso de listas
                    listCiclistas.Add(objc);
                    dgCiclistas.Items.Add(objc);
                }
                statusCiclista.Value = 0;
            }
        }
        private void btnAgregarCiclista_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresarCiclistas.IsOpen = true;

        }

        private async void BtnModificarCiclista_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Aviso", "Pulse el ciclista que desea modificar");
            if (dgCiclistas.SelectedItem != null)
            {
                modciclista = true;

                string id = (dgCiclistas.SelectedItem as clCiclistas).ID;
                clCiclistas competidor = listCiclistas.FirstOrDefault(x => x.ID == id);
                txtNombreCiclista.Text = competidor.Nombre;
                txtApellidoCiclista.Text = competidor.Apellido;
                txtDorsalCiclista.Text = competidor.Dorsal;
                txtIDCiclista.Text = competidor.ID;
                txtEquipoCiclista.Text = competidor.Equipo;
                comboBoxPaisCiclista.Text = competidor.Pais;
                this.flyIngresarCiclistas.IsOpen = true;

                listCiclistas.Remove(competidor);
            }
            else
                await this.ShowMessageAsync("¡Atención!", "Debe seleccionar un ciclista, por favor.");
        }

        private async void BtnEliminarCiclista_Click(object sender, RoutedEventArgs e)
        {
            if (dgCiclistas.SelectedItem != null)
            {
                listCiclistas.RemoveAt(dgCiclistas.SelectedIndex);
                //dgCiclistas.ItemsSource = null;
                dgCiclistas.Items.RemoveAt(dgCiclistas.SelectedIndex);
            }
            else
            {
                await this.ShowMessageAsync("Atención", "Debe seleccionar un ciclista, por favor");
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

        private async void btnEliminarEtapa_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Aviso", "Pulse la etapa que desea eliminar");
            eliminar = true;
        }
        private async void btnModificarEtapa_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("Aviso", "Pulse la etapa que desea modificar");
            modificar = true;

        }
        private void panel_Click(object sender, RoutedEventArgs e)
        {
            // Recopero el nombre del panel
            char[] titulo = e.Source.ToString().ToCharArray();
            // Separo el numero de etapa
            int num = int.Parse(titulo[titulo.Length - 1].ToString());

            Etapa numetapa = listEtapas.FirstOrDefault(x => x.numero == num);

            lblKilometros.Content = numetapa.kilometros.ToString();
            lblNumero.Content = numetapa.numero.ToString();
            TextRange textRange = new TextRange(rchDescripcionEtapa.Document.ContentStart, rchDescripcionEtapa.Document.ContentEnd);
            lblDescipcion.Content = numetapa.descripcion;
            lblUbicacion.Content = numetapa.Lugar;

            imagen1.Visibility = Visibility.Hidden;

            lbl1.Visibility = Visibility.Visible;
            lbl2.Visibility = Visibility.Visible;
            lbl3.Visibility = Visibility.Visible;
            lbl4.Visibility = Visibility.Visible;

            lblKilometros.Visibility = Visibility.Visible;
            lblNumero.Visibility = Visibility.Visible;
            lblDescipcion.Visibility = Visibility.Visible;
            lblUbicacion.Visibility = Visibility.Visible;

            //pbImagen1.Visibility = Visibility.Visible;

            if (eliminar || modificar)
            {
                imagen1.Visibility = Visibility.Visible;

                lbl1.Visibility = Visibility.Hidden;
                lbl2.Visibility = Visibility.Hidden;
                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;

                lblKilometros.Visibility = Visibility.Hidden;
                lblNumero.Visibility = Visibility.Hidden;
                lblDescipcion.Visibility = Visibility.Hidden;
                lblUbicacion.Visibility = Visibility.Hidden;

                //pbImagen1.Visibility = Visibility.Hidden;
            }

            if (eliminar)
            {
                stack.Children.Remove(e.Source as Tile);
                var itemToRemove = listEtapas.Single(r => r.numero == num);
                listEtapas.Remove(itemToRemove);
                eliminar = false;

            }

            if (modificar)
            {
                this.PanelModificar = (e.Source as Tile);
                //EnumVisual(stack);
                txtKilometrosEtapa.Text = numetapa.kilometros.ToString();
                txtNumEtapa.Text = numetapa.numero.ToString();
                textRange.Text = numetapa.descripcion;
                txtUbicacionEtapa.Text = numetapa.Lugar;
                //(e.Source as Tile).Content = "Etapa " + txtNumEtapa.Text;
                //modificar = false;
                this.flyIngresoEtapa.IsOpen = true;

            }


        }

        private void btnAgregarEtapa_Click(object sender, RoutedEventArgs e)
        {
            this.flyIngresoEtapa.IsOpen = true;
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

        Etapa objetapa = new Etapa();
        private async void btnIngresarEtapa_Click(object sender, RoutedEventArgs e)
        {

            objetapa.kilometros = int.Parse(txtKilometrosEtapa.Text);
            objetapa.numero = int.Parse(txtNumEtapa.Text);
            TextRange range = new TextRange(rchDescripcionEtapa.Document.ContentStart, rchDescripcionEtapa.Document.ContentEnd);
            objetapa.descripcion = range.Text;
            objetapa.Lugar = txtUbicacionEtapa.Text;

            //Uso de listas 
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChangedEtapa;

            worker.RunWorkerAsync();





            //Etapa numetapa = listEtapas.FirstOrDefault(x => x.numero == int.Parse(txtNumEtapa.Text));

            //if (modificar)
            //{
            //    if (numetapa == null)
            //    {
            //        PanelModificar.Content = "Etapa " + txtNumEtapa.Text;
            //        listEtapas.Add(objetapa);
            //        modificar = false;
            //    } else
            //    {
            //        await this.ShowMessageAsync("Aviso", "Número de etapa ya existe");
            //    }
            //}
            //else
            //{

            //    //MessageBox.Show(numetapa.numero.ToString());
            //    if (numetapa == null)
            //    {
            //        listEtapas.Add(objetapa);
            //        crearTilesEtapas("Etapa " + objetapa.numero);
            //    }
            //    else
            //        await this.ShowMessageAsync("Aviso", "Número de etapa ya existe");
            //}



            //txtKilometrosEtapa.Clear();
            //txtNumEtapa.Clear();
            //rchDescripcionEtapa.Document.Blocks.Clear();
            //txtUbicacionEtapa.Clear();



        }

        private async void worker_ProgressChangedEtapa(object sender, ProgressChangedEventArgs e)
        {
            estadoEtapa.Value = e.ProgressPercentage;
            if (estadoEtapa.Value == 100)
            {
                Etapa numetapa = listEtapas.FirstOrDefault(x => x.numero == int.Parse(txtNumEtapa.Text));

                if (modificar)
                {
                    if (numetapa == null)
                    {
                        PanelModificar.Content = "Etapa " + txtNumEtapa.Text;
                        listEtapas.Add(objetapa);
                        modificar = false;
                    }
                    else
                    {
                        await this.ShowMessageAsync("Aviso", "Número de etapa ya existe");
                    }
                }
                else
                {

                    //MessageBox.Show(numetapa.numero.ToString());
                    if (numetapa == null)
                    {
                        listEtapas.Add(objetapa);
                        crearTilesEtapas("Etapa " + objetapa.numero);
                    }
                    else
                        await this.ShowMessageAsync("Aviso", "Número de etapa ya existe");
                }



                txtKilometrosEtapa.Clear();
                txtNumEtapa.Clear();
                rchDescripcionEtapa.Document.Blocks.Clear();
                txtUbicacionEtapa.Clear();

                this.flyIngresoEtapa.IsOpen = false;

                statusCiclista.Value = 0;
            }
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



        private void txtNumCorredoresCompetencia_KeyDown(object sender, KeyEventArgs e)
        {

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



        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(4);
            }
        }

       

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