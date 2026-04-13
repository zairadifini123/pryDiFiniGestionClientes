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
                while (Vector.Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text) && i < Vector.INDICE) 
                {
                    i++;
                }

                if (i== Vector.INDICE)
                {
                    Vector.Clientes[Vector.INDICE].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vector.Clientes[Vector.INDICE].Usuario = txtUsuario.Text;
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

        private void Listar()
        {
            Decimal TotalDeuda = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.INDICE; i++)
            {
                dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
            }

            lblTotalDeuda.Text = TotalDeuda.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            PreCarga();
            Listar();
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

        private void PreCarga()
        {
            Vector.Clientes[Vector.INDICE].Codigo = 10;
            Vector.Clientes[Vector.INDICE].Usuario = "Ana";
            Vector.Clientes[Vector.INDICE].Deuda = 400;
            Vector.Clientes[Vector.INDICE].Limite = 10000;
            Vector.INDICE++;

            Vector.Clientes[Vector.INDICE].Codigo = 20;
            Vector.Clientes[Vector.INDICE].Usuario = "Diego";
            Vector.Clientes[Vector.INDICE].Deuda = 0;
            Vector.Clientes[Vector.INDICE].Limite = 20000;
            Vector.INDICE++;

            Vector.Clientes[Vector.INDICE].Codigo = 30;
            Vector.Clientes[Vector.INDICE].Usuario = "Maria";
            Vector.Clientes[Vector.INDICE].Deuda = 852;
            Vector.Clientes[Vector.INDICE].Limite = 60000;
            Vector.INDICE++;
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal TotalDeuda = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.INDICE; i++)
            {
                if (Vector.Clientes[i].Deuda>0)
                {
                    dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                    TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
                }
            }

            lblTotalDeuda.Text = TotalDeuda.ToString();
        }

    }
}