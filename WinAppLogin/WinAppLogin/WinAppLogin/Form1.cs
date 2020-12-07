using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLogin
{
    public partial class Form1 : Form
    {

        string Usuario = "Admin";
        string Contrasena = "Admin";
        string[] Admin = new string[2];

        public Form1()
        {
            InitializeComponent();

            txt_Password.UseSystemPasswordChar = true;
            btn_Ingresar.Enabled = false;
            txt_Password.Enabled = false;
            checkcontra.Enabled = false;
        }

        private void pxb_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string name = txt_User.Text;
                    if (name == Usuario)
                    {

                        txt_Password.Enabled = true;
                        checkcontra.Enabled = true;
                        txt_Password.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no existente", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_User.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Dato Ingresado no valido", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_User.Clear();
                }
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e).KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string contra = txt_Password.Text;
                    if (contra == Contrasena)
                    {
                        btn_Ingresar.Enabled = true;
                        btn_Ingresar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Contrasena invalida", "Error de Contrasena", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Password.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Dato Ingresado no valido", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Password.Clear();
                }
            }
        }

        private void checkcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcontra.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
                pxb_visible.Visible = true;
                pxb_novisible.Visible = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
               pxb_visible.Visible = false;
                pxb_novisible.Visible = true;

            }
        }
    }
}
