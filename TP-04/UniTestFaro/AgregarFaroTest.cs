using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace UniTestFaro
{

    [TestClass]
    public class AgregarFaroTest
    {
        /// <summary>
        /// Prueba unitaria verifica que un elemento existe en la lista y devuelve true.
        /// </summary>
        [TestMethod]
        public void AgregarFaro()
        {
            FaroLed faroLed = new FaroLed(1,"faroNuevo",Faro.EMedida.Mediano,2,FaroLed.ETipoLed.Micro);
            FaroLed faroLed2 = new FaroLed(1,"faroNuevo",Faro.EMedida.Mediano,2,FaroLed.ETipoLed.Micro);
            Fabrica.FarosLed.Add(faroLed);
            Fabrica.FarosLed.Add(faroLed2);
            bool test = Fabrica.FarosLed == faroLed2;
            Assert.IsTrue(test);
        }
    }
}
