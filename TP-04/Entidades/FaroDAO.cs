using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaroDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

       
        /// <summary>
        /// Constructor
        /// </summary>
        public FaroDAO()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=FaroStock; Integrated Security=True;";
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
      
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
                comando.CommandText = sql;

                conexion.Open();

                comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw new ArchivoException("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }

        /// <summary>
        /// Inserta un producto a la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public bool InsertarFaro(Faro faro)
        {
            string sql = "Insert into FaroStock(nombre, idFaro, medida, tipo, stock) " +
                "values(@auxNombre, @auxID, @auxMedida, @auxTipo, @auxStock)";

            comando.Parameters.Add(new SqlParameter("@auxDescripcion", faro.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxID", faro.Id));
            comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida));
            comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));
            //comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

            return EjecutarNonQuery(sql);
        }
        /// <summary>
        /// Modifica un producto de la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se modifico, false caso contrario</returns>
        public bool ModificarProducto(Faro faro)
        {
            string sql = "Insert into FaroStock(nombre, idFaro, medida, tipo, stock) " +
               "values(@auxNombre, @auxID, @auxMedida, @auxTipo, @auxStock)";

            comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxID", faro.Id));
            comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida));
            comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));
            //comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

            return EjecutarNonQuery(sql);
        }

        /// <summary>
        /// Elimina un producto de la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>true si se elimino, false caso contrario</returns>
        public bool EliminarProducto(Faro faro)
        {
            string sql = "Delete Productos where id = @auxID";

            comando.Parameters.Add(new SqlParameter("@auxID", faro.Id));

            return EjecutarNonQuery(sql);
        }

        /// <summary>
        /// Trae el listado de todos los productos guardados en la base de datos
        /// </summary>
        /// <returns>Lista de productos</returns>
        public List<Faro> Leer()
        {
            List<Faro> productos = new List<Faro>();

            try
            {
                comando.CommandText = "Select * from Productos";

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();

                    if (tipo == "lámpara")
                    {
                        productos.Add(new FaroLampara(int.Parse(reader["idProducto"].ToString()), reader["descripcion"].ToString(),
                        (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString())));

                    }
                    else
                    {
                        productos.Add(new FaroLed(int.Parse(reader["idProducto"].ToString()), reader["descripcion"].ToString(),
                        (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString()), (FaroLed.ETipoLed)(reader["tipoLed"])));
                    }


                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw new ArchivoException("Falla al intentar leer la base de datos", e);

            }
            finally
            {
                conexion.Close();
            }

            return productos;
        }

        /// <summary>
        /// Trae un producto de la base de datos identificado con el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de tipo producto</returns>
        public Faro LeerPorID(int id)
        {
            Faro faro = null;

            try
            {
                comando.CommandText = "Select * from Productos where id = " + id.ToString();

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();

                    if (tipo == "lámpara")
                    {
                        faro = new FaroLampara(int.Parse(reader["idProducto"].ToString()), reader["descripcion"].ToString(),
                        (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString()));

                    }
                    else
                    {
                        faro = new FaroLed(int.Parse(reader["idProducto"].ToString()), reader["descripcion"].ToString(),
                        (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString()), (FaroLed.ETipoLed)(reader["tipoLed"]));
                    }


                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("Falla al intentar leer la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            return faro;
        }
    }
}