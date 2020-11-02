using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instansiables;
using Clases_Abstractas;
namespace TestsUnitarios
{
    [TestClass]
    public class AlumnoExistente
    {
        [TestMethod]
        public void TestMethod1()
        {
            Alumno alumno = new Alumno(3, "Bruno", "de Renzis", "39104689", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);
        }
    }
}
