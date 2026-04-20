using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniGestionClientes
{
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.INDICE < Vector.Clientes.Length)
            {
                Int32 i = 0;
                while (i < Vector.INDICE && Vector.Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text)) 
                {
                    i++;
                }

                if (i== Vector.INDICE)
                {
                    Vector.Clientes[Vector.INDICE].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.Clientes[Vector.INDICE].Nombre = txtUsuario.Text;
                    Vector.Clientes[Vector.INDICE].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vector.Clientes[Vector.INDICE].Limite = Convert.ToDecimal(txtLimite.Text);
                    Vector.INDICE++;
                    MessageBox.Show("Los datos se cargaron correctamente");
                    txtCodigo.Text = "";
                    txtUsuario.Text = "";
                    txtDeuda.Text = "";
                    txtLimite.Text = "";
                }

                else
                {
                    MessageBox.Show("El código ya existe, ingrese otro");
                    txtCodigo.Text = "";
                }
            }

            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
        }

        

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            e.Handled =
                !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                (e.KeyChar != ',' || t.Text.Contains(","));

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            e.Handled =
                !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                (e.KeyChar != ',' || t.Text.Contains(","));
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Comprobar ()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

     
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}