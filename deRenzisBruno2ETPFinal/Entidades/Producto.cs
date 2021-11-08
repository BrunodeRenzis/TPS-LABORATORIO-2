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
        /// <summary>
        /// Constructor por defecto de la clase producto
        /// </summary>
        public Producto()
        {
            this.NombreProducto = String.Empty;
        }

        /// <summary>
        /// Constructor con parámetros de la clase producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="nombreProducto"></param>
        /// <param name="tipo"></param>
        public Producto(int idProducto,string nombreProducto, ETipo tipo)
        {
            this.IdProducto = idProducto;
            this.NombreProducto = nombreProducto;
            this.Tipo = tipo;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }

        /// <summary>
        /// Hardcodeo de productos para utilizar como archivo xml en el programa
        /// </summary>
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
        /// <summary>
        /// Sobrecarga del método ToString
        /// </summary>
        /// <returns>NombreProducto</returns>
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
        /// <summary>
        /// Sobrecarga del operador == de la clase Producto
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>true si un producto de lista es igual al id del producto pasado, false caso contrario</returns>
        public static bool operator ==(List<Producto> productos, Producto producto)
        {

            foreach (Producto productoComp in Mensajeria.Productos)
            {
                if (productoComp.IdProducto == producto.IdProducto)
                    return true;
            }


            return false;
        }

        /// <summary>
        /// Sobrecarga del operador != de la clase Producto
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>true si un producto de lista es distinto al id del producto pasado, false caso contrario</returns>
        public static bool operator !=(List<Producto> productos, Producto producto)
        {
            return !(productos == producto);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>Devuelve una lista con el producto a agregar si este no se encuentra en la lista, caso contrario arroja excepción</returns>
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

    
    public enum ETipo
    {
        Indumentaria,
        Perfumería,
        Entretenimiento,
        Cocina
    }
}
