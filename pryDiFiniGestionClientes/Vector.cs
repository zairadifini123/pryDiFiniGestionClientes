using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDiFiniGestionClientes
{
    internal class Vector
    {
        public struct RegClientes
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }

        static public RegClientes[] Clientes = new RegClientes[10];

        static public Int32 INDICE = 0;
    }
}
