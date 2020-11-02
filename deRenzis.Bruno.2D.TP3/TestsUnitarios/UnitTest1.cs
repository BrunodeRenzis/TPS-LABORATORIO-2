using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Abstractas;
using Clases_Instansiables;
using Excepciones;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestMethod1()
        {
            Alumno a = new Alumno(2, "Bruno", "de Renzis", "39104y6t", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
        }
    }
}
