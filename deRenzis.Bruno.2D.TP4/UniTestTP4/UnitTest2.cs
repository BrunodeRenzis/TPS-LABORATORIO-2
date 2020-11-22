using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UniTestTP4
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Console.WriteLine("\nId incorrecto prueba: ");
                Venta unaVenta = new Venta();

                unaVenta += 18;

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }


        }
    }
}
