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

namespace WpfAppCompetenciaCiclistica.Controles
{
    /// <summary>
    /// Lógica de interacción para Etapas.xaml
    /// </summary>
    public partial class Etapas : UserControl
    {
        bool eliminar = false;
        public Etapas()
        {
            InitializeComponent();
            //crearTilesEtapas("etapa1");
            //crearTilesEtapas("etapa2");
            //crearTilesEtapas("etapa3");
        }

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

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
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

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            IngresarEtapas objIngresar = new IngresarEtapas();
            objIngresar.ShowDialog();
        }
    }
}
