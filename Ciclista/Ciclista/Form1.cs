using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclista
{
    public partial class frm_RegistroCiclistas : Form
    {
        string nom, ape, id, equi, dor, pa;
        string idBus;//variable que voy a buscar 
        int posicion; //me coje la posicion del  parametro que quiero modificar


        public void limpiar()
        {
            txt_nom.Clear();
            txt_ape.Clear();
            txt_id.Clear();
            txt_equi.Clear();
            cmb_dorsal.Text = "";
            cmb_pais.Text = "";
        }
        //registrar ciclistas
        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            //GuardarCiclista ();
            //limpiar();
            //btn_modificar.Enabled = true;
            
            //txt_nom.Focus();
            //MessageBox.Show("Agregado", " Ciclista ", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Asterisk);
            
        }

      

        private void txt_equi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    equi = txt_equi.Text.ToUpper();
                    cmb_dorsal.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       

        private void txt_id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    id = txt_id.Text;
                    txt_equi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmb_dorsal_SelectedIndexChanged(object sender, EventArgs e)
        {
            dor =cmb_dorsal.SelectedItem.ToString();
                
            cmb_pais.Focus();
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            pa = cmb_pais.SelectedItem.ToString();
            btn_ingresar.Focus();
        }

        private void txt_ape_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ape = txt_ape.Text.ToUpper() ;
                    txt_id.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
     

        

        private void txt_nom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    nom = txt_nom.Text.ToUpper();
                    txt_ape.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //metodo para que se me muestren los valores en los txt
        private void dataCiclista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataCiclista.CurrentRow.Index;
            //posicion= dataCiclista.Rows.Count - 1;
            //MessageBox.Show(posicion.ToString());
            txt_nom.Text = dataCiclista[0, posicion].Value.ToString();
            txt_ape.Text = dataCiclista[1, posicion].Value.ToString();
            txt_id.Text = dataCiclista[2, posicion].Value.ToString();
            txt_equi.Text = dataCiclista[3, posicion].Value.ToString();
            cmb_dorsal.Text = dataCiclista[4, posicion].Value.ToString();
            cmb_pais.Text = dataCiclista[5, posicion].Value.ToString();

           // btn_ingresar.Enabled = false;
            btn_modificar.Enabled = true;
            txt_nom.Focus();

        }
        //metodo para modifciar los datos del data gridview

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            nom = txt_nom.Text;
            ape = txt_ape.Text;
            id = txt_id.Text;
            equi = txt_equi.Text;
            dor = cmb_dorsal.SelectedItem.ToString();
            pa = cmb_pais.SelectedItem.ToString();

            dataCiclista[0, posicion].Value = txt_nom.Text;
            dataCiclista[1, posicion].Value = txt_ape.Text;
            dataCiclista[2, posicion].Value = txt_id.Text;
            dataCiclista[3, posicion].Value = txt_equi.Text;
            dataCiclista[4, posicion].Value = cmb_dorsal.Text;
            dataCiclista[5, posicion].Value = cmb_pais.Text;
            txt_nom.Focus();
            MessageBox.Show("Ciclista modificado");



        }

        public frm_RegistroCiclistas()
        {
            InitializeComponent();
        }

        private void frm_RegistroCiclistas_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        //creo lista de ciclistas
        List<clCiclista> listaCiclistas = new List<clCiclista>();

        //metodo para guardar los datos en una lista
        public void GuardarCiclista()
        {

            clCiclista ciclista1 = new clCiclista(nom, ape, id, equi, dor, pa);

             Ciclistas objC = new Ciclistas(); 

            this.Close();
            
            //listaCiclistas.Add(ciclista1);
            //dataCiclista.Visible = true;
            //dataCiclista.DataSource = null;//actualiza el datagridview
            //dataCiclista.DataSource = listaCiclistas;//añade la lista al datagridview
        }

        
        
        //metodo para modificar ciclistas recorriendo una lista
        /*
       
        public void modificarCiclista(string idBus)
        {
           
            foreach (var ci in listaCiclistas)
            {
                if (ci.ID==idBus)
                {
                    
                    ci.Nombre = txt_nom.Text;
                    ci.Apellido = txt_ape.Text;
                    ci.ID = txt_id.Text;
                    ci.Equipo = txt_equi.Text;
                    ci.Dorsal = cmb_dorsal.SelectedIndex.ToString();
                    ci.Pais = cmb_pais.SelectedItem.ToString();
                    MessageBox.Show("cilcista modificado");
                    break;
                    

                }
                else
                {
                    MessageBox.Show("ciclista no encontrado");
                }
               
            }

        }
        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            modificarCiclista(idBus);
            dataCiclista.DataSource = null;//actualiza el datagridview
            dataCiclista.DataSource = listaCiclistas;//añade la lista al datagridview
            txt_idBuscar.Clear();
        }

        private void txt_idBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    idBus = txt_idBuscar.Text;
                    btn_modificar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        */

        



    }
}
