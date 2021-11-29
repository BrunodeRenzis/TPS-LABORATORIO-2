using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestVarios
    {
        [TestMethod]
        [ExpectedException (typeof(PedidoRepetidoException))]
        public void TestPedidoRepetidoException()
        {
            Cliente clienteTest = new Cliente("Bruno","de Renzis",Persona.ESexo.Hombre,"Combate de juncal 943",1,ELocalidad.ZonaSur);
            List<Producto> productoTest = new List<Producto>();
            Pedido pedidoTest = new Pedido(clienteTest,productoTest);
            Mensajeria.Pedidos += pedidoTest;
            Mensajeria.Pedidos += pedidoTest;

        }

        [TestMethod]
        public void TraeListaDB()
        {
            Mensajeria.Productos = DB.TraerProductos();
            Assert.IsNotNull(Mensajeria.Productos);
            Assert.IsTrue(Mensajeria.Productos.Count > 0);
        }

        [TestMethod]
        public void HayProductosIndumentaria()
        {
            Mensajeria.Productos = DB.TraerProductos();
            Assert.IsTrue(Mensajeria.Productos.Exists((x) => x.Tipo == ETipo.Indumentaria));
        }
        [TestMethod]
        public void HayProductosCocina()
        {
            Mensajeria.Productos = DB.TraerProductos();
            Assert.IsTrue(Mensajeria.Productos.Exists((x) => x.Tipo == ETipo.Cocina));
        }
        [TestMethod]
        public void HayClientesZonaSur()
        {
            Mensajeria.Clientes = DB.TraerClientes();
            Assert.IsTrue(Mensajeria.Clientes.Exists((x) => x.Localidad == ELocalidad.ZonaSur));
        }

    }
}
