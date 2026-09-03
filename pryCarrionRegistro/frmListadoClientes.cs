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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();

            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvListado.Rows.Add(clsVector.arrClientes[i].codigo, clsVector.arrClientes[i].nombre, clsVector.arrClientes[i].limitecredito, clsVector.arrClientes[i].deuda);
                deuda += clsVector.arrClientes[i].deuda;
            }

            lblCantidadClientes.Text = clsVector.indice.ToString();

            lblTotalDeuda.Text = "$" + deuda.ToString();

            lblPromedioDeuda.Text = "$" + (deuda / clsVector.indice).ToString();
        }

        decimal deuda = 0;

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
