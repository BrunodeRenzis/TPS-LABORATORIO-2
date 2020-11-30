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
        /// <summary>
        /// Evalua la excepción de un alumno repetido
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestMethod1()
        {
            
           
                Universidad universidad = new Universidad();
                Alumno unAlumno = new Alumno(1, "Bruno", "de Renzis", "39104689",
                Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
                Alumno.EEstadoCuenta.AlDia);

                universidad += unAlumno;
                universidad += unAlumno;
        }
    }
}
