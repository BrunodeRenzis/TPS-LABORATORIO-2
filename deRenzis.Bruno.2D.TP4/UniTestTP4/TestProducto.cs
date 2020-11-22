using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace UniTestTP4
{
    [TestClass]
    public class TestProducto
    {
        [TestMethod]
        public void TestMethod1()
        {
            Producto testProducto = new ProductoSinCadenaFrio("Jabón", 25.5, Producto.ETipoProducto.SinCadenaFrio, 25);
        }
    }
}
