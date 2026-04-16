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
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        static public RegClientes[] Clientes = new RegClientes[10];

        static public Int32 INDICE = 0;

        static public void OrdenarPorCodigoAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE -1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorCodigoDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorNombreAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Nombre.CompareTo(Clientes[i + 1].Nombre)> 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorNombreDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Nombre.CompareTo(Clientes[i + 1].Nombre) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorLimiteAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorLimiteDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Limite < Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorDeudaAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void OrdenarPorDeudaDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegClientes Aux;
            while (c < INDICE - 1)
            {
                i = 0;
                while (i < INDICE - 1)
                {
                    if (Clientes[i].Deuda < Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

        static public void CargaDatosDePrueba()
        {
            Clientes[INDICE].Codigo = 10;
            Clientes[INDICE].Nombre = "Ana";
            Clientes[INDICE].Deuda = 400;
            Clientes[INDICE].Limite = 10000;
            INDICE++;

            Clientes[INDICE].Codigo = 20;
            Clientes[INDICE].Nombre = "Diego";
            Clientes[INDICE].Deuda = 0;
            Clientes[INDICE].Limite = 20000;
            INDICE++;

            Clientes[INDICE].Codigo = 30;
            Clientes[INDICE].Nombre = "Maria";
            Clientes[INDICE].Deuda = 852;
            Clientes[INDICE].Limite = 60000;
            INDICE++;
        }
    }
}
