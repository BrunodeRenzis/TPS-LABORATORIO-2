using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Excepciones;
namespace Entidades
{
    public static class DB
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static DB()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = DESKTOP - PEHMTAT\\SQLEXPRESS; Initial Catalog=Productos; Integrated Security = True";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool EjecutarNonQuery(string sql)
        {
            bool ejecucion = false;
            try
            {
                comando.CommandText = sql;

                conexion.Open();

                comando.ExecuteNonQuery();
                ejecucion = true;
            }
            catch (Exception e)
            {
                ejecucion = false;
                throw new ArchivoException("Falla al intentar trabajar sobre la base de datos",e);
            }
            finally
            {
                conexion.Close();
            }

            return ejecucion;
        }

        public static List<Producto> Leer()
        {
            List<Producto> listaProductos = new List<Producto>();

            try
            {
                comando.CommandText = "Select * from Productos";

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipoProducto"].ToString();

                    if (tipo == "SinCadenaFrio")
                    {
                        listaProductos.Add(new ProductoSinCadenaFrio(reader["nombreProducto"].ToString(), double.Parse(reader["PrecioProducto"].ToString()), 
                         Producto.ETipoProducto.SinCadenaFrio, int.Parse(reader["cantidadProducto"].ToString()), int.Parse(reader["idProducto"].ToString())));

                    }
                    else
                    {
                        listaProductos.Add(new ProductoCadenaFrio(reader["nombreProducto"].ToString(), double.Parse(reader["PrecioProducto"].ToString()),
                         Producto.ETipoProducto.SinCadenaFrio, int.Parse(reader["cantidadProducto"].ToString()), int.Parse(reader["idProducto"].ToString())));
                    }


                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw new ArchivoException("No se puede leer la base de datos", e);

            }
            finally
            {
                conexion.Close();
            }

            return listaProductos;
        }

        public static bool AgregarProducto(Producto unProducto)
        {
            string sql = "Insert into Productos(idProducto,nombreProducto,cantidadProducto, precioProducto, tipoProducto) " +
                "values(@auxNombre, @auxID, @auxPrecio, @auxCantidad, @auxTipo)";

            comando.Parameters.Add(new SqlParameter("@auxID", unProducto.Id));
            comando.Parameters.Add(new SqlParameter("@auxNombre", unProducto.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxCantidad", unProducto.Cantidad));
            comando.Parameters.Add(new SqlParameter("@auxPrecio", unProducto.Precio));
            comando.Parameters.Add(new SqlParameter("@auxTipo", unProducto.TipoProducto.ToString()));

            return EjecutarNonQuery(sql);
        }

        public static bool EliminarProducto(Producto unProducto)
        {
            string sql = "Delete Productos where idProducto = @auxID";

            comando.Parameters.Add(new SqlParameter("@auxID", unProducto.Id));

            return EjecutarNonQuery(sql);
        }

        public static bool ModificarProducto(Producto unProducto)
        {
            string sql = "Update Productos Set nombreProducto = @auxNombre, idProducto = @auxID, " +
                "precioProducto = @auxPrecio, cantidadProducto = @auxCantidad, tipoProducto = @auxTipo where idProducto = @auxID";

            comando.Parameters.Add(new SqlParameter("@auxNombre", unProducto.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxID", unProducto.Id));
            comando.Parameters.Add(new SqlParameter("@auxPrecio", unProducto.Precio));
            comando.Parameters.Add(new SqlParameter("@auxCantidad", unProducto.Cantidad));
            comando.Parameters.Add(new SqlParameter("@auxTipo", unProducto.TipoProducto.ToString()));

            return EjecutarNonQuery(sql);
        }



    }
}
