using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
namespace UniTestFaro
{

    [TestClass]
    public class AgregarFaroTest
    {
        /// <summary>
        /// Prueba unitaria de agregar elemento a la lista
        /// </summary>
        [TestMethod]
        public void AgregarFaro()
        {
            FaroLed faroLed = new FaroLed("faroNuevo",Faro.EMedida.Mediano,2,FaroLed.ETipoLed.Micro);
            Fabrica.FarosLed.Add(faroLed);
            Assert.IsNotNull(Fabrica.FarosLed);
        }
    }
}
