using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Entidades
{
    public static class DB
    {
        static private SqlConnection conexion;
        static private SqlCommand comando;
        static private SqlDataReader reader;
        static DB()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=tp4; Integrated Security=True;";
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public static bool EjecutarNonQuery(string sql)
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
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }
        public static List<Cliente> TraerClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            comando.CommandText = "SELECT * FROM Clientes";
            ELocalidad localidad = ELocalidad.ZonaSur;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    if (reader["localidad"].ToString().Equals("ZonaSur"))
                    {
                        localidad = ELocalidad.ZonaSur;
                    }

                    if (reader["localidad"].ToString().Equals("ZonaOeste"))
                    {
                        localidad = ELocalidad.ZonaOeste;
                    }

                    if (reader["localidad"].ToString().Equals("CABA"))
                    {
                        localidad = ELocalidad.CABA;
                    }
                    string sexo = reader["sexo"].ToString();
                    if(sexo.Contains("Hombre"))
                    {
                        lista.Add(new Cliente(reader["nombre"].ToString(),reader["apellido"].ToString(),Persona.ESexo.Hombre,reader["direccion"].ToString(),
                        int.Parse(reader["idCliente"].ToString()),localidad));
                    }

                    else if (sexo.Contains("Mujer"))
                    {
                        lista.Add(new Cliente(reader["nombre"].ToString(), reader["apellido"].ToString(), Persona.ESexo.Mujer , reader["direccion"].ToString(),
                        int.Parse(reader["idCliente"].ToString()),localidad));
                    }

                    else if(sexo.Contains("Binario"))
                    {
                        lista.Add(new Cliente(reader["nombre"].ToString(), reader["apellido"].ToString(), Persona.ESexo.Binario, reader["direccion"].ToString(),
                        int.Parse(reader["idCliente"].ToString()),localidad));
                    }
                }
                return lista;
            } 
            catch(Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }

            finally
            {
                conexion.Close();
            }
        }
        public static List<Producto> TraerProductos()
        {
            List<Producto> lista = new List<Producto>();
            comando.CommandText = "SELECT * FROM Productos";
            try
            {

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string tipoProducto = reader["Tipo"].ToString();
                    if(tipoProducto == "Perfumería")
                        lista.Add(new Producto(int.Parse(reader["idProducto"].ToString()),reader["nombreProducto"].ToString(),ETipo.Perfumería));
                    if(tipoProducto == "Indumentaria")
                        lista.Add(new Producto(int.Parse(reader["idProducto"].ToString()),reader["nombreProducto"].ToString(),ETipo.Indumentaria));
                    if (tipoProducto == "Cocina")
                        lista.Add(new Producto(int.Parse(reader["idProducto"].ToString()), reader["nombreProducto"].ToString(), ETipo.Cocina));
                    if (tipoProducto == "Entretenimiento")
                        lista.Add(new Producto(int.Parse(reader["idProducto"].ToString()), reader["nombreProducto"].ToString(), ETipo.Entretenimiento));
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }

            finally
            {
                conexion.Close();
            }
        }

 

        public static void TraerListasDB()
        {
            Mensajeria.Clientes = DB.TraerClientes();
            Mensajeria.Productos = DB.TraerProductos();
            
        }

        private static string SepararProductos(List<Producto> productos)
        {
            string nombreProductos = String.Empty;
            foreach (Producto producto in productos)
            {
                nombreProductos += producto.NombreProducto; 
            }

            return nombreProductos;
        }

        public static bool PedidoNuevo(Pedido pedido)
        {
            try
            {
                comando.Parameters.Clear();
                

                comando.CommandText = $"Insert into Pedidos (idCliente,nombreCliente,productos,estadoPedido) values ({pedido.Cliente.IdCliente},'{pedido.Cliente.Nombre}','{SepararProductos(pedido.Productos)}','{pedido.Estado}'); ";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

                
                return true;

            }
            catch (DBConcurrencyException ex)
            {
                throw new DBConcurrencyException(ex.Message,ex.InnerException);
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

        }



    }
}
