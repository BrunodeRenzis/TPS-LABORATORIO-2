using System;
using System.Collections.Generic;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente("Cosme", "Fulanito", Persona.ESexo.Hombre, "Avenida siempreviva 742", 1,ELocalidad.ZonaSur);
            Cliente unaClienta = new Cliente("Cosma", "Fulanita", Persona.ESexo.Mujer, "Avenida siempreviva 742", 2,ELocalidad.ZonaOeste);
            Cliente uneCliente = new Cliente("Cosme", "Fulanite", Persona.ESexo.Binario, "Avenida siempreviva 742", 3,ELocalidad.CABA);
            Producto productoUno = new Producto(1, "Zapatillas", ETipo.Indumentaria);
            Producto productoDos = new Producto(2, "Desodorante", ETipo.Perfumería);
            Producto productoTres = new Producto(3, "Tostadora", ETipo.Cocina);
            Producto productoCuatro = new Producto(4, "Ojotas", ETipo.Indumentaria);
            Producto productoCinco = new Producto(4, "Cuchillo tramontina", ETipo.Indumentaria);
            Producto productoSeis = new Producto(5, "Fumanji", ETipo.Entretenimiento);
            Producto productoSiete = new Producto(6, "Vaso térmico", ETipo.Cocina);
            Producto productoOcho = new Producto(7, "Zapatillas", ETipo.Indumentaria);
            Producto productoNueve = new Producto(8, "Cuchara", ETipo.Cocina);
            Producto productoDiez = new Producto(9, "Rexona", ETipo.Perfumería);
            List<Producto> productosUno = new List<Producto>();
            List<Producto> productosDos = new List<Producto>();
            List<Producto> productosTres = new List<Producto>();
            List<Producto> productosCuatro = new List<Producto>();
            List<Pedido> pedidos = new List<Pedido>();
            List<Pedido> pedidosDos = new List<Pedido>();
            List<Pedido> pedidosTres = new List<Pedido>();
            List<Pedido> pedidosCuatro = new List<Pedido>();
            
            //Primera lista de productos
            productosUno+=productoUno;
            productosUno+=productoDos;
            productosUno+=productoTres;
            productosUno+=productoTres;
            productosUno+=productoCuatro;

            //Segunda lista de productos
            productosDos += productoNueve;
            productosDos += productoUno;
            productosDos += productoSeis;
            productosDos += productoTres;

            //Tercera lista de productos
            productosTres += productoOcho;
            productosTres += productoDos;
            productosTres += productoSiete;
            productosTres += productoTres;

            //Cuarta lista de productos
            productosCuatro += productoCinco;
            productosCuatro += productoCuatro;
            productosCuatro += productoNueve;
            productosCuatro += productoDiez;
            productosCuatro += productoDos;

            Pedido nuevoPedido = new Pedido(unCliente,productosUno);
            Pedido nuevoPedidoDos = new Pedido(unaClienta,productosDos);
            Pedido nuevoPedidoTres = new Pedido(uneCliente,productosTres);
            Pedido nuevoPedidoCuatro = new Pedido(uneCliente,productosCuatro);
            pedidos.Add(nuevoPedido);
            pedidosDos.Add(nuevoPedidoDos);
            pedidosTres.Add(nuevoPedidoTres);
            pedidosCuatro.Add(nuevoPedidoCuatro);
            Console.WriteLine("Probando la sobrecarga de operadores, la tostadora debería aparecer una sola vez y el cuchillo no debería aparecer dado que tiene el mismo id que las ojotas.\n");
            foreach (Producto producto in productosUno)
            {
                Console.WriteLine($"Producto agregado a la lista: {producto}\n");
            }
            Console.WriteLine("Probando informe de Categorías\n");
            Console.WriteLine(Informe.SexoQueMasCompraUnaCategoria(pedidos,ETipo.Entretenimiento));
            Console.WriteLine(Informe.SexoQueMasCompraUnaCategoria(pedidosDos,ETipo.Cocina));
            Console.WriteLine(Informe.SexoQueMasCompraUnaCategoria(pedidosTres,ETipo.Perfumería));
            Console.WriteLine(Informe.SexoQueMasCompraUnaCategoria(pedidosCuatro,ETipo.Indumentaria));
            Console.ReadLine();
        }
    }
}
