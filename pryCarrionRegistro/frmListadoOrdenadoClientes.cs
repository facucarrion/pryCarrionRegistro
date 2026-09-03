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
    public partial class frmListadoOrdenadoClientes : Form
    {
        public frmListadoOrdenadoClientes()
        {
            InitializeComponent();

            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvListado.Rows.Add(clsVector.arrClientes[i].codigo, clsVector.arrClientes[i].nombre, clsVector.arrClientes[i].limitecredito, clsVector.arrClientes[i].deuda);
            }
        }

        clsVector objVector = new clsVector();

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (lstCriterio.SelectedIndex)
            {
                case 0:
                    if (lstModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        objVector.OrdenarPorCodigoDescendente();
                    }
                    break;
                case 1:
                    if (lstModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarPorNombreAscendente();
                    }
                    else
                    {
                        objVector.OrdenarPorNombreDescendente();
                    }
                    break;
                case 2:
                    if (lstModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarPorLimiteAscendente();
                    }
                    else
                    {
                        objVector.OrdenarPorLimiteDescendente();
                    }
                    break;
                case 3:
                    if (lstModo.SelectedIndex == 0)
                    {
                        objVector.OrdenarPorDeudaAscendente();
                    }
                    else
                    {
                        objVector.OrdenarPorDeudaDescendente();
                    }
                    break;
            }

            dgvListado.Rows.Clear();

            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvListado.Rows.Add(clsVector.arrClientes[i].codigo, clsVector.arrClientes[i].nombre, clsVector.arrClientes[i].limitecredito, clsVector.arrClientes[i].deuda);
            }
        }
    }
}
