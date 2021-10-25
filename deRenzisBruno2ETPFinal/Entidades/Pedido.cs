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
        Cliente cliente;
        string descripcion;
        List<Producto> productos;
        EEstado estado;

        public Pedido()
        {
            
            this.cliente = null;
            this.descripcion = String.Empty;
            this.Productos = new List<Producto>();
            this.estado = EEstado.NoEntregado;
        }

        public Pedido(Cliente cliente, string descripcion, List<Producto> productos, EEstado estado)
        {
            this.cliente = cliente;
            this.descripcion = descripcion;
            this.Productos = productos;
            this.estado = estado;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public EEstado Estado { get => estado; set => estado = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        public static bool operator ==(List<Pedido> pedidos, Pedido pedido)
        {
            foreach (Pedido pedidoComp in Mensajeria.Pedidos)
            {
                if (pedidoComp.Equals(pedido))
                    return true;
            }

            return false;
        }

        public static bool operator !=(List<Pedido> pedidos, Pedido pedido)
        {
            return !(pedidos == pedido);
        }
        public static List<Pedido> operator +(List<Pedido> pedidos, Pedido pedido)
        {
            if(Mensajeria.Pedidos!=pedido)
            {
                Mensajeria.Pedidos.Add(pedido);
                return Mensajeria.Pedidos;
            }

            return Mensajeria.Pedidos;
        }
    }

    

    public enum EEstado
    {
        NoEntregado,
        Entregado
    }

    public enum ETipo
    {
        Indumentaria,
        Perfumería,
        Entretenimiento,
        Cocina
    }
}
