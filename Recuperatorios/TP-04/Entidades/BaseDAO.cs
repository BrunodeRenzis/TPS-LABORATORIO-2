using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class BaseDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;


        /// <summary>
        /// Constructor
        /// </summary>
        public BaseDAO()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=FaroStock; Integrated Security=True;";
            Comando = new SqlCommand();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
        }

        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }

        /// <summary>
        /// Ejecuta ExecuteNonQuery() en una conexion SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>True si se ejecuto, false caso contrario</returns>
        public bool EjecutarNonQuery(string sql)
        {
            bool ejecuto = false;
            try
            {
                Comando.CommandText = sql;

                Conexion.Open();

                Comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw new ArchivoException("Fallo al intentar conectar a base de datos", e);
            }
            finally
            {
                Conexion.Close();
            }

            return ejecuto;
        }
    }
}
