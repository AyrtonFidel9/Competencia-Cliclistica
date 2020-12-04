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
    /// Lógica de interacción para IngresoCompetencia.xaml
    /// </summary>
    public partial class IngresoCompetencia : Window
    {
        public IngresoCompetencia()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtNombre1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtUbicacion.Focus();
            }
        }

        private void txtUbicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                rchDespripcion.Focus();
            }
        }

        private void rchDespripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtNumCorredores.Focus();
            }
        }

        private void txtNumCorredores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnIngresar.Focus();
            }
        }
    }
}
