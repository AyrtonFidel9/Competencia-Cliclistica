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

namespace WpfAppCompetenciaCiclistica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            //txtBTitulo.Text = "Inicio";
        }

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
                        frNavegacion.Navigate(new Uri("/Controles/Inicio.xaml", UriKind.Relative));
                        break;
                    case "Competencia":
                        txtBTitulo.Text = "Competencia";
                        frNavegacion.Navigate(new Uri("/Controles/Competencia.xaml", UriKind.Relative));

                        break;
                    case "Etapas":
                        txtBTitulo.Text = "Etapas";
                        frNavegacion.Navigate(new Uri("/Controles/Etapas.xaml", UriKind.Relative));

                        break;
                    case "Ciclistas":
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
    }
}
