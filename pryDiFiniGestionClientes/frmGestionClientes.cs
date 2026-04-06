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

        private struct RegClientes
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegClientes[] Clientes = new RegClientes[10];

        private Int32 INDICE = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (INDICE < Clientes.Length)
            {
                Clientes[INDICE].Codigo = Convert.ToInt32(txtCodigo.Text);
                Clientes[INDICE].Usuario = txtUsuario.Text;
                Clientes[INDICE].Deuda = Convert.ToDecimal(txtDeuda.Text);
                Clientes[INDICE].Limite = Convert.ToDecimal(txtLimite.Text);
                INDICE++;
                Listar();
                MessageBox.Show("Los datos se cargaron correctamente");
                txtCodigo.Text = "";
                txtUsuario.Text = "";
                txtDeuda.Text = "";
                txtLimite.Text = "";
            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
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
            for (Int32 i = 0; i < INDICE; i++)
            {
                dgvClientes.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Clientes[i].Deuda;
            }

            lblTotalDeuda.Text = "Total Deuda: " + TotalDeuda.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
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
    }
}