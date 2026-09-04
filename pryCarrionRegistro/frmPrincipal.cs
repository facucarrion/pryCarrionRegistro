using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionRegistro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            clsVector.Precarga();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarClientes frmAgregarClientes = new frmAgregarClientes();
            frmAgregarClientes.ShowDialog();
        }

        private void ordenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoOrdenadoClientes frmListadoOrdenadoClientes = new frmListadoOrdenadoClientes();
            frmListadoOrdenadoClientes.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeudores frmListadoDeudores = new frmListadoDeudores();
            frmListadoDeudores.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
