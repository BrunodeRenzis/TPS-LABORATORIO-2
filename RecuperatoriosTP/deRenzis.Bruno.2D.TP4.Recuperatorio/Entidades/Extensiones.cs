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
        public static string ExtensionMostrar(this List<Producto> listaProductos)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LISTA DE PRODUCTOS CADENA FRIO");

            foreach (Producto unProducto in Comercio.ListaProductos)
            {
                if(unProducto.TipoProducto == Producto.ETipoProducto.CadenaFrio)
                sb.AppendLine(unProducto.ToString());
            }


            return sb.ToString();
        }
    }
}
