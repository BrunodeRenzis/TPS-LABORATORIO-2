using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoSinCadenaFrio:Producto
    {
        public ProductoSinCadenaFrio(string nombre, double precio, Producto.ETipoProducto tipoProducto, int cantidad, int id):base(nombre,precio,tipoProducto,cantidad,id)
        {

        }
        public ProductoSinCadenaFrio(string nombre, double precio, Producto.ETipoProducto tipoProducto, int cantidad) : base(nombre, precio, tipoProducto, cantidad)
        {

        }

        protected override string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nProducto sin cadena de frio");
            sb.AppendLine(base.MostrarProductos());


            return sb.ToString();
        }

        /// <summary>
        /// override del metodo ToString
        /// </summary>
        /// <returns>los datos cargaddos en el metodo Mostrar</returns>
        public override string ToString()
        {
            return this.MostrarProductos();
        }

    }
}

