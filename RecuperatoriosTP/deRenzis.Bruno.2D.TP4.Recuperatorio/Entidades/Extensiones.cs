using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace System.Collections.Generic
{
    public static class Extensiones
    {

        public static int StockProductosTotal(this List<Producto> listaProductos)
        {
            int totalProd = 0;

            foreach (Producto unProducto in listaProductos)
            {
                totalProd += unProducto.Cantidad;
            }

            return totalProd;
        }

        public static string ExtensionMostrar(this List<Producto> listaProductos)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LISTA DE PRODUCTOS");

            foreach (Producto unProducto in Comercio.ListaProductos)
            {
                sb.AppendLine(unProducto.ToString());
            }


            return sb.ToString();
        }
    }
}
