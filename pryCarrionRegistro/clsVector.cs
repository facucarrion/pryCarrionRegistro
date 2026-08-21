using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCarrionRegistro
{
    internal class clsVector
    {
        // Estructura
        public struct RegCliente {
            public int codigo;
            public decimal deuda;
            public string usuario;
            public decimal limite;
        }

        public static RegCliente[] clientes = new RegCliente[5];

        public static int indice = 0;

        public void Agregar(Int32 codigoRecibido, Decimal deudaRecibida, String usuarioRecibido, Decimal limiteRecibido)
        {
            if (indice < clientes.Length)
            {
            }
        }
    }
}
