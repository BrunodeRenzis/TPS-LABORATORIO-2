using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using Entidades;
namespace UniTestTP4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestMethod1()
        {
            Producto testProducto = new ProductoCadenaFrio("Jamón", 25.5, Producto.ETipoProducto.CadenaFrio, 25);
        }
    }
}
