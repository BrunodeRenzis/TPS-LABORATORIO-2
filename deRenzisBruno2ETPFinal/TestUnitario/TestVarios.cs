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
        [ExpectedException(typeof(ClienteException))]
        public void NoAgregaRepeditoTest()
        {
            Cliente clienteTest = new Cliente("Bruno", "de Renzis", Persona.ESexo.Hombre, "Combate de juncal 943", 1,ELocalidad.ZonaOeste);
            List<Cliente> clientesTest = new List<Cliente>();
            clientesTest += clienteTest;
            clientesTest += clienteTest;
            Assert.AreEqual(clientesTest.Count, 1);
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
        
    }
}
