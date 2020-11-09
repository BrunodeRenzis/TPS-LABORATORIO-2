using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        public static List<Cliente> listaClientes;
        public static List<Producto> listaProductos;
        public static List<Vendedor> listaVendedores;
        public static List<Venta> listaVentas;
        
        static Comercio()
        {
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();
            listaVendedores = new List<Vendedor>();
            listaVentas = new List<Venta>();
        }
    }
}
