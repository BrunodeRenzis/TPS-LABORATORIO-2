using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instansiables;
using Clases_Abstractas;
namespace TestsUnitarios
{
    [TestClass]
    public class TestNuevoAlumno
    {
        /// <summary>
        /// Evalua la correcta instanciación de un alumno
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Alumno alumno = new Alumno(3, "Bruno", "de Renzis", "39104689", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);
        }
    }
}
