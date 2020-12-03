using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(ProductoCadenaFrio))]
    [XmlInclude(typeof(ProductoSinCadenaFrio))]
    [XmlInclude(typeof(Producto))]
    public class Producto
    {
        public int id;
        public string nombre;
        public double precio;
        public int cantidad;
        public ETipoProducto tipoProducto;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public ETipoProducto TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Constructor utilizado para agregar un producto a la base de datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="cantidad"></param>
        public Producto(string nombre, double precio, ETipoProducto tipoProducto, int cantidad)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.TipoProducto = tipoProducto;
            this.Cantidad = cantidad;
        }

        /// <summary>
        /// Constructor utilizado para levantar productos de la base de datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="cantidad"></param>
        /// <param name="id"></param>
        public Producto()
        {

        }
        public Producto(string nombre)
        {
            this.Nombre = nombre;
        }
        public Producto(string nombre, double precio, ETipoProducto tipoProducto, int cantidad, int id) : this(nombre, precio, tipoProducto, cantidad)
        {
            this.Id = id;
        }
        public enum ETipoProducto
        {
            CadenaFrio,
            SinCadenaFrio,
            SinEspecificar
        }

        protected virtual string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID Producto: {this.id.ToString()}");
            sb.AppendLine($"Nombre Producto: {this.nombre}");
            sb.AppendLine($"Cantidad: {this.cantidad.ToString()}");
            sb.AppendLine($"Precio: { this.precio}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarProductos();
        }

        public bool Guardar()
        {
            return DB.AgregarProducto(this);
        }

        public bool Borrar()
        {
            return DB.EliminarProducto(this);
        }

        public bool Modificar()
        {
            return DB.ModificarProducto(this);
        }

        public static bool operator ==(Producto unProducto,List<Producto> listaProductos)
        {
            foreach (Producto prod in Comercio.ListaProductos)
            {
                if(prod.Id == unProducto.Id)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Producto unProducto, List<Producto> listaProductos)
        {
            return !(unProducto == listaProductos);
        }

        public static bool operator + (Producto unProducto,List<Producto> listaProductos)
        {
            if(unProducto != listaProductos)
            {
                unProducto.Guardar();
                return true;
            }
            return false;
        }

        public static bool operator -(Producto unProducto, List<Producto> listaProductos)
        {
            if (unProducto == listaProductos)
            {
                unProducto.Borrar();
                return true;
            }
            return false;
        }
    }
}
