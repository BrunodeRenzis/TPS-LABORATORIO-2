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

        #region Constructor
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
        #endregion

        #region Metodos
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
            comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

            return EjecutarNonQuery(sql);
        }
        /// <summary>
        /// Modifica un producto de la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se modifico, false caso contrario</returns>
        public bool ModificarProducto(Faro faro)
        {
            string sql = "Update Productos Set descripcion = @auxDescripcion, idProducto = @auxID, " +
                "precio = @auxPrecio, cantidad = @auxCantidad, tipoProducto = @auxTipo where idProducto = @auxID";

            comando.Parameters.Add(new SqlParameter("@auxDescripcion", faro.Descripcion));
            comando.Parameters.Add(new SqlParameter("@auxID", faro.Id));
            comando.Parameters.Add(new SqlParameter("@auxPrecio", faro.Precio));
            comando.Parameters.Add(new SqlParameter("@auxCantidad", faro.Cantidad));
            comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

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
                    string tipo = reader["tipoProducto"].ToString();

                    if (tipo == "perecedero")
                    {
                        productos.Add(new ProductoPerecedero(reader["descripcion"].ToString(), int.Parse(reader["idProducto"].ToString()),
                        double.Parse(reader["Precio"].ToString()), int.Parse(reader["cantidad"].ToString()), Producto.ETipo.perecedero));

                    }
                    else
                    {
                        productos.Add(new ProductoNoPerecedero(reader["descripcion"].ToString(), int.Parse(reader["idProducto"].ToString()),
                        double.Parse(reader["Precio"].ToString()), int.Parse(reader["cantidad"].ToString()), Producto.ETipo.noPerecedero));
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
                    string tipo = reader["tipoProducto"].ToString();

                    if (tipo == "perecedero")
                    {
                        faro = new ProductoPerecedero(reader["descripcion"].ToString(), id,
                        double.Parse(reader["Precio"].ToString()), int.Parse(reader["cantidad"].ToString()), Producto.ETipo.perecedero);

                    }
                    else
                    {
                        faro = new ProductoNoPerecedero(reader["descripcion"].ToString(), id,
                        double.Parse(reader["Precio"].ToString()), int.Parse(reader["cantidad"].ToString()), Producto.ETipo.noPerecedero);
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

            return faro;
        }
    }
}