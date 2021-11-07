using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class PedidoNoGeneradoExceptionTest
    {
        [TestMethod]
        [ExpectedException (typeof(PedidoRepetidoException))]
        public void TestPedidoRepetidoException()
        {
            Cliente clienteTest = new Cliente("Bruno","de Renzis",Persona.ESexo.Hombre,"Combate de juncal 943",1);
            List<Producto> productoTest = new List<Producto>();
            Pedido pedidoTest = new Pedido(clienteTest,productoTest,EEstado.Entregado);
            Mensajeria.Pedidos += pedidoTest;
            Mensajeria.Pedidos += pedidoTest;

        }

        [TestMethod]
        [ExpectedException(typeof(ClienteException))]
        public void NoAgregaRepeditoTest()
        {
            Cliente clienteTest = new Cliente("Bruno", "de Renzis", Persona.ESexo.Hombre, "Combate de juncal 943", 1);
            List<Cliente> clientesTest = new List<Cliente>();
            clientesTest += clienteTest;
            clientesTest += clienteTest;
            Assert.AreEqual(clientesTest.Count, 1);
        }

        
    }
}
