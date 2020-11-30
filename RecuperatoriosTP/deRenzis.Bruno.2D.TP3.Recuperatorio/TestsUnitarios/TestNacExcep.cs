using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Abstractas;
using Clases_Instansiables;
using Excepciones;
namespace TestsUnitarios
{
    [TestClass]
    public class TestNacExcep
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestMethod1()
        {
            Universidad universidad = new Universidad();
            Alumno a1 = new Alumno(1, "Bruno", "de Renzis", "39104689",
            Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(1, "Bruno", "de Renzis", "39104689",
            Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.AlDia);

            universidad += a1;

            try
            {
                universidad += a2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }
    }
}
