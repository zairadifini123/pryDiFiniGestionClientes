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
    public partial class frmClientesManejo : Form
    {
        public frmClientesManejo()
        {
            InitializeComponent();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionClientes f = new frmGestionClientes();
            f.MdiParent = this; 
            f.Show(); 
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoOrdenado f = new frmListadoOrdenado();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeClientes f = new frmListadoDeClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoDeDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarDeudores f = new frmListarDeudores();
            f.MdiParent = this;
            f.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientesManejo_Load(object sender, EventArgs e)
        {
  
            Vector.Clientes[Vector.INDICE].Codigo = 10;
            Vector.Clientes[Vector.INDICE].Nombre = "Ana";
            Vector.Clientes[Vector.INDICE].Deuda = 400;
            Vector.Clientes[Vector.INDICE].Limite = 10000;
            Vector.INDICE++;

            Vector.Clientes[Vector.INDICE].Codigo = 20;
            Vector.Clientes[Vector.INDICE].Nombre = "Diego";
            Vector.Clientes[Vector.INDICE].Deuda = 0;
            Vector.Clientes[Vector.INDICE].Limite = 20000;
            Vector.INDICE++;

            Vector.Clientes[Vector.INDICE].Codigo = 30;
            Vector.Clientes[Vector.INDICE].Nombre = "Maria";
            Vector.Clientes[Vector.INDICE].Deuda = 852;
            Vector.Clientes[Vector.INDICE].Limite = 60000;
            Vector.INDICE++;
        }
    
    }
}
