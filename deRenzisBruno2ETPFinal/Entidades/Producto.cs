using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int idProducto;
        string nombreProducto;
        ETipo tipo;

        public Producto()
        {
            this.NombreProducto = String.Empty;
        }
        public Producto(int idProducto,string nombreProducto, ETipo tipo)
        {
            this.IdProducto = idProducto;
            this.NombreProducto = nombreProducto;
            this.Tipo = tipo;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }

        public static void HardcodearXmlProductos()
        {

            try
            {
                Mensajeria.Productos.Add(new Producto(1, "Perfume avon", ETipo.Perfumería));
                Mensajeria.Productos.Add(new Producto(2, "Cuchillo chef Tramontia", ETipo.Cocina));
                Mensajeria.Productos.Add(new Producto(3, "Uno", ETipo.Entretenimiento));
                Mensajeria.Productos.Add(new Producto(4, "Ajedrez", ETipo.Entretenimiento));
                Mensajeria.Productos.Add(new Producto(5, "Pantalón Chupín", ETipo.Indumentaria));
                Mensajeria.Productos.Add(new Producto(6, "Sauvage Dior", ETipo.Perfumería));
                Mensajeria.Productos.Add(new Producto(7, "Wok Tramontina", ETipo.Cocina));
                Mensajeria.Productos.Add(new Producto(8, "Vestido Summer Limited Edition", ETipo.Indumentaria));
                Mensajeria.Productos.Add(new Producto(9, "Mesa Pool-PingPong", ETipo.Entretenimiento));
                Mensajeria.Productos.Add(new Producto(10, "Kit vasos", ETipo.Cocina));
                Mensajeria.GuardarProductos(Mensajeria.Productos);
            }

            catch (ArchivoException ex)
            {
                throw new ArchivoException(ex.Message, ex);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in Mensajeria.Productos)
            {
                sb.AppendLine($"{NombreProducto}");
                break;
            }
            return sb.ToString();
        }

        public static bool operator ==(List<Producto> productos, Producto producto)
        {

            foreach (Producto productoComp in Mensajeria.Productos)
            {
                if (productoComp.IdProducto == producto.IdProducto)
                    return true;
            }


            return false;
        }

        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }
        public static List<Producto> operator +(List<Producto> productos, Producto producto)
        {
            try
            {
                if (Mensajeria.Productos != producto)
                {
                    Mensajeria.Productos.Add(producto);
                    return Mensajeria.Productos;
                }
            }

            catch (Exception e)
            {
                throw new ProductoRepetidoException("No se pudo agregar el producto por que ya existe", e);
            }
           
            return Mensajeria.Productos;

        }


    }

    [Serializable]
    internal class ProductoRepetidoException : Exception
    {
        public ProductoRepetidoException()
        {
        }

        public ProductoRepetidoException(string message) : base(message)
        {
        }

        public ProductoRepetidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductoRepetidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public enum ETipo
    {
        Indumentaria,
        Perfumería,
        Entretenimiento,
        Cocina
    }
}
