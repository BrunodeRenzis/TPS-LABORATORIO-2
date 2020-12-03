using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoCadenaFrio:Producto
    {
        public ProductoCadenaFrio()
        {

        }
        public ProductoCadenaFrio(string nombre, double precio, Producto.ETipoProducto tipoProducto, int cantidad) :base(nombre,precio,tipoProducto,cantidad)
        {
               
        }

        public ProductoCadenaFrio(string nombre, double precio, Producto.ETipoProducto tipoProducto, int cantidad,int id) : base(nombre,precio,tipoProducto,cantidad,id)
        {

        }
    }
}
