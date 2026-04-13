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
    }
}
