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
    public partial class frmListadoDeClientes : Form
    {
        public frmListadoDeClientes()
        {
            InitializeComponent();
        }

        private void frmListadoDeClientes_Load(object sender, EventArgs e)
        {
            Listar();
            CantidadClientes();
            PromedioDeudas();
        }

        
        private void Listar()
        {
            Decimal TotalDeuda = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.INDICE; i++)
            {
                dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Nombre, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
            }

            lblTotalDeuda.Text = TotalDeuda.ToString();
        }

        private void CantidadClientes()
        {
            Int32 CantidadClientes = 0;
            for (Int32 i = 0; i < Vector.INDICE; i++)
            {
                CantidadClientes++; 
            }
            lblCantidadClientes.Text = CantidadClientes.ToString();
        }

        private void PromedioDeudas()
        {
            Decimal TotalDeuda = 0;
            dgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vector.INDICE; i++)
            {
                dgvClientes.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Nombre, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
            }
            lblPromedioDeudas.Text = (Vector.INDICE > 0) ? (TotalDeuda / Vector.INDICE).ToString("F2") : "0";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
