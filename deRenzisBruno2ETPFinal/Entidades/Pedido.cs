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

        public Pedido()
        {
            this.Productos = new List<Producto>();
            this.Estado = EEstado.Generado;
            id++;
        }

        public Pedido(Cliente cliente, List<Producto> productos, EEstado estado):this()
        {
            this.IdPedido = id;
            this.Cliente = cliente;
            this.Productos = productos;
            this.Estado = estado;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public EEstado Estado { get => estado; set => estado = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        public static bool operator ==(List<Pedido> pedidos, Pedido pedido)
        {
           
                foreach (Pedido pedidoComp in Mensajeria.Pedidos)
                {
                    if (pedidoComp.IdPedido == pedido.IdPedido)
                        throw new PedidoRepetidoException();
                }
            
                        
            return false;
        }

        public static bool operator !=(List<Pedido> pedidos, Pedido pedido)
        {
            return !(pedidos == pedido);
        }
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

        public static List<Pedido> operator -(List<Pedido> pedidos, Pedido pedido)
        {
            if(Mensajeria.Pedidos==pedido)
            {
                Mensajeria.Pedidos.Remove(pedido);
                return Mensajeria.Pedidos;
            }
            return Mensajeria.Pedidos;
        }

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
