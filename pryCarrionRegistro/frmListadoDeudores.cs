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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();

            for (int i = 0; i < clsVector.indice; i++)
            {
                if (clsVector.arrClientes[i].deuda > 0)
                {
                    dgvListado.Rows.Add(clsVector.arrClientes[i].codigo, clsVector.arrClientes[i].nombre, clsVector.arrClientes[i].limitecredito, clsVector.arrClientes[i].deuda);
                    deuda += clsVector.arrClientes[i].deuda;
                }
            }

            lblTotalDeuda.Text = "$" + deuda.ToString();
        }

        decimal deuda = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoDeudores_Load(object sender, EventArgs e)
        {

        }
    }
}
