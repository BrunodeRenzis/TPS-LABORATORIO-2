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
            Cliente clienteTest = new Cliente("Bruno","de Renzis","39104689","20391046892",Persona.ESexo.Hombre,"Combate de juncal 943",1);
            List<Producto> productoTest = new List<Producto>();
            Pedido pedidoTest = new Pedido(1,clienteTest,"PedidoTest",productoTest,EEstado.Entregado);
            Mensajeria.Pedidos += pedidoTest;
            Mensajeria.Pedidos += pedidoTest;

        }
    }
}
