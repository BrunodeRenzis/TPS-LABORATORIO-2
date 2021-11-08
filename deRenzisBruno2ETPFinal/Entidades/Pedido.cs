using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Pedido
    {
        int idPedido;
        static int id=0;
        Cliente cliente;
        List<Producto> productos;
        EEstado estado;

        /// <summary>
        /// Constructor por defecto pedido, creara la lista de productos, asignará el estado de generado y preparará el id de pedido a asignar. 
        /// </summary>
        public Pedido()
        {
            this.Productos = new List<Producto>();
            this.Estado = EEstado.Generado;
            id++;
        }

        /// <summary>
        /// Constructor con parámetros de pedido,asignará el cliente y lista de productos
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="productos"></param>
        /// <param name="estado"></param>
        public Pedido(Cliente cliente, List<Producto> productos):this()
        {
            this.IdPedido = id;
            this.Cliente = cliente;
            this.Productos = productos;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public EEstado Estado { get => estado; set => estado = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="pedido"></param>
        /// <returns>Si los productos son iguales arroja excepción,caso contrario retorna falso </returns>
        public static bool operator ==(List<Pedido> pedidos, Pedido pedido)
        {
           
                foreach (Pedido pedidoComp in Mensajeria.Pedidos)
                {
                    if (pedidoComp.IdPedido == pedido.IdPedido)
                        throw new PedidoRepetidoException();
                }
            
                        
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="pedido"></param>
        /// <returns>Si los productos no son iguales arroja excepción,caso contrario retorna falso </returns>
        public static bool operator !=(List<Pedido> pedidos, Pedido pedido)
        {
            return !(pedidos == pedido);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="pedido"></param>
        /// <returns>retorna la lista de pedidos con pedido nuevo si el pedido es distinto a los que ya existen, caso contrario arroja excepción</returns>
        public static List<Pedido> operator +(List<Pedido> pedidos, Pedido pedido)
        {
            try
            {
                if(Mensajeria.Pedidos!=pedido)
                {
                    Mensajeria.Pedidos.Add(pedido);
                    return Mensajeria.Pedidos;
                }
            }

            catch(Exception e)
            {
                throw new PedidoRepetidoException("No se pudo generar el pedido por que ya existe",e);
            }
            return Mensajeria.Pedidos;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="pedido"></param>
        /// <returns>retorna la lista de pedidos con pedido eliminado si el pedido es igual a alguno de los que ya existen, caso contrario devuelve la misma lista</returns>
        public static List<Pedido> operator -(List<Pedido> pedidos, Pedido pedido)
        {
            if(Mensajeria.Pedidos==pedido)
            {
                Mensajeria.Pedidos.Remove(pedido);
                return Mensajeria.Pedidos;
            }
            return Mensajeria.Pedidos;
        }
        
        /// <summary>
        /// Sobrecarga del método ToString, muestra el nombre del producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in Productos)
            {
                sb.AppendLine(item.NombreProducto);
            }
            return sb.ToString();
        }
    }

    public enum EEstado
    {
        Generado,
        NoEntregado,
        Entregado
    }
}
