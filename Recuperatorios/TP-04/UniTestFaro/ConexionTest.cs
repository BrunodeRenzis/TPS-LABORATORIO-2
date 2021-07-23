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
        public void Conexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=FaroStock; Integrated Security=True;");
            conexion.Open();

            Assert.AreEqual(System.Data.ConnectionState.Open,conexion.State);
        }
    }
}
