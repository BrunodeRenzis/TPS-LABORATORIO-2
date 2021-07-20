using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Collections.Generic;

namespace UniTestFaro
{
    [TestClass]
    public class ArchivoExceptionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void TestArchivoException()
        {
            List<string> aux = new List<string>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "exception.txt";
            Texto txtFile = new Texto();
            txtFile.Escribir(path, "Exception");
            Xml<List<string>> xml = new Xml<List<string>>();

            aux = xml.Leer(path);
        }
    }
}
