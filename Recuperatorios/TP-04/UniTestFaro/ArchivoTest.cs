using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UniTestFaro
{
    [TestClass]
    public class ArchivoTest
    {
        [TestMethod]
        public void LecturaArchivo()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "FarosLampara.xml";
            Xml<Faro> xml = new Xml<Faro>();
            xml.Leer(path);
            Assert.IsNotNull(xml);
        }
    }
}
