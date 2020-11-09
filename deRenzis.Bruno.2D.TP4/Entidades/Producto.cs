using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombre;
        double precio;
        int cantidad;
        ETipoProducto tipoProducto;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public ETipoProducto TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(string nombre, double precio, ETipoProducto tipoProducto, int cantidad)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.TipoProducto = tipoProducto;
            this.Cantidad = cantidad;
        }
        public enum ETipoProducto
        {
            Perecedero,
            NoPerecedero
        }

        public static bool operator + (Producto unProducto, List<Producto> listaProductos)
        {
            for (int i=0;i<listaProductos.Count;i++)
            {
                if(unProducto.Nombre != listaProductos[i].Nombre)
                {
                    listaProductos.Add(unProducto);
                    return true;
                }

            }
            return false;
        }
    }
}
