using System;
using System.Collections.Generic;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente("Cosme", "Fulanito", Persona.ESexo.Hombre, "Avenida siempreviva 742", 1);
            Cliente unaClienta = new Cliente("Cosma", "Fulanita", Persona.ESexo.Mujer, "Avenida siempreviva 742", 2);
            Cliente uneCliente = new Cliente("Cosme", "Fulanite", Persona.ESexo.Binario, "Avenida siempreviva 742", 3);
            Producto productoUno = new Producto(1, "Zapatillas", ETipo.Indumentaria);
            Producto productoDos = new Producto(2, "Desodorante", ETipo.Perfumería);
            Producto productoTres = new Producto(3, "Tostadora", ETipo.Cocina);
            Producto productoCuatro = new Producto(4, "Ojotas", ETipo.Indumentaria);
            Producto productoCinco = new Producto(4, "Cuchillo tramontina", ETipo.Indumentaria);
            List<Producto> productos = new List<Producto>();
            List<Pedido> pedidos = new List<Pedido>();
            productos+=productoUno;
            productos+=productoDos;
            productos+=productoTres;
            productos+=productoTres;
            productos+=productoCuatro;
            Pedido nuevoPedido = new Pedido(unCliente,productos);
            Pedido nuevoPedidoDos = new Pedido(unaClienta,productos);
            Pedido nuevoPedidoTres = new Pedido(uneCliente,productos);
            Pedido nuevoPedidoCuatro = new Pedido(uneCliente,productos);
            pedidos.Add(nuevoPedido);
            pedidos.Add(nuevoPedidoDos);
            pedidos.Add(nuevoPedidoTres);
            pedidos.Add(nuevoPedidoCuatro);
            Console.WriteLine("Probando la sobrecarga de operadores, la tostadora debería aparecer una sola vez y el cuchillo no debería aparecer dado que tiene el mismo id que las ojotas.\n");
            foreach (Producto producto in productos)
            {
                Console.WriteLine($"Producto agregado a la lista: {producto}\n");
            }
            Console.WriteLine("Probando informe de sexos\n");
            Console.WriteLine(Informe.SexoMasPedidos(pedidos));
            Console.ReadLine();
        }
    }
}
