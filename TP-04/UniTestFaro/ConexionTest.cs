using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Data.SqlClient;

namespace UniTestFaro
{
    [TestClass]
    public class ConexionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=FaroStock; Integrated Security=True;");
                conexion.Open();
            }

            catch (ConexionException ex)
            {
                throw new Exception("No se pudo conectar", ex);
            }
        }
    }
}
