using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionRegistro
{
    internal class clsVector
    {
        public struct RegCliente {
            public int codigo;
            public decimal deuda;
            public string nombre;
            public decimal limitecredito;
        }

        public static RegCliente[] arrClientes = new RegCliente[5];

        public static int indice = 0;

        public static void Precarga()
        {
            arrClientes[indice] = new RegCliente
            {
                codigo = 1,
                deuda = 0,
                nombre = "Juan Pérez",
                limitecredito = 1000
            };
            indice++;

            arrClientes[indice] = new RegCliente
            {
                codigo = 2,
                deuda = 0,
                nombre = "María Gómez",
                limitecredito = 2000
            };
            indice++;

            arrClientes[indice] = new RegCliente
            {
                codigo = 3,
                deuda = 200,
                nombre = "Carlos López",
                limitecredito = 1500
            };
            indice++;
        }

        public static void Agregar(String codigoRecibido, String deudaRecibida, String usuarioRecibido, String limiteRecibido)
        {
            if (indice >= arrClientes.Length)
            {
                MessageBox.Show("Límite de clientes alcanzado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arrClientes[indice].codigo = Convert.ToInt32(codigoRecibido);
            arrClientes[indice].deuda = Convert.ToDecimal(deudaRecibida);
            arrClientes[indice].nombre = usuarioRecibido;
            arrClientes[indice].limitecredito = Convert.ToDecimal(limiteRecibido);
            indice++;
        }

        public void OrdenarPorCodigoAscendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].codigo > arrClientes[j + 1].codigo)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }
                }
            }
        }

        public void OrdenarPorCodigoDescendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].codigo < arrClientes[j + 1].codigo)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }
                }
            }
        }

        public void OrdenarPorNombreAscendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].nombre.CompareTo(arrClientes[j + 1].nombre) > 0)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }

        public void OrdenarPorNombreDescendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].nombre.CompareTo(arrClientes[j + 1].nombre) < 0)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }

        public void OrdenarPorDeudaAscendente()
        {
            RegCliente temp;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].deuda > arrClientes[j + 1].deuda)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }

        public void OrdenarPorDeudaDescendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].deuda < arrClientes[j + 1].deuda)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }

        public void OrdenarPorLimiteAscendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].limitecredito > arrClientes[j + 1].limitecredito)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }


        public void OrdenarPorLimiteDescendente()
        {
            RegCliente temp;

            for (Int32 i = 0; i < indice - 1; i++)
            {
                for (Int32 j = 0; j < indice - 1; j++)
                {
                    if (arrClientes[j].limitecredito < arrClientes[j + 1].limitecredito)
                    {
                        temp = arrClientes[j];
                        arrClientes[j] = arrClientes[j + 1];
                        arrClientes[j + 1] = temp;
                    }

                }
            }
        }
    }
}
