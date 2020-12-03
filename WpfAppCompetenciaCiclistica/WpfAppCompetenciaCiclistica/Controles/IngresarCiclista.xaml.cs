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
using WpfAppCompetenciaCiclistica.Clases;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WpfAppCompetenciaCiclistica.Controles
{
    /// <summary>
    /// Lógica de interacción para IngresarCiclista.xaml
    /// </summary>
    public partial class IngresarCiclista : CustomDialog
    {
        public IngresarCiclista()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.Key == Key.Enter)
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
            Ciclistas objCicli = new Ciclistas();
            //clase1 objc = new clase1();
            //MessageBox.Show(nom + ap + id + equipo + dorsal + pais);
            //objc.Nombre = txtNombre.Text;
            //objc.Apellido = txtApellido.Text;
            //objc.ID = txtID.Text;
            //objc.Equipo = txtEquipo.Text;
            //objc.Dorsal = txtDorsal.Text;
            //objc.Pais = comboBoxPais.Text;
            
            objCicli.recibirParametros(txtNombre.Text, txtApellido.Text, txtID.Text, txtEquipo.Text, txtDorsal.Text, comboBoxPais.Text);
            //objCicli.dgCiclistas.Items.Add(objc);
           
        }

        private async void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            await(this.OwningWindow
              ?? (MetroWindow)Application.Current.MainWindow).HideMetroDialogAsync(this);
        }
    }


}
