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
using System.Windows.Shapes;

namespace WpfAppCompetenciaCiclistica.Controles
{
    /// <summary>
    /// Lógica de interacción para IngresarEtapas.xaml
    /// </summary>
    public partial class IngresarEtapas : Window
    {
        public IngresarEtapas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtKilometrosEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                e.Handled = true;
            }
            //e.Key >= Key.A && e.Key <= Key.Z   esto para letras
            if (e.Key == Key.Enter)
            {
                txtUbicacionEtapa.Focus();
            }
        }

        private void txtUbicacionEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtUbicacionEtapa.Focus();
            }
        }

        private void txtNumEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                rchDescripciónEtapa.Focus();
            }
        }

        private void rchDescripciónEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnIngresarEtapa.Focus();
            }

        }

        private void btnIngresarEtapa_Click(object sender, RoutedEventArgs e)
        {
            //IngresarEtapas.AcceptButton = btnIngresarEtapa;
        }

        private void txtKilometrosEtapa_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
