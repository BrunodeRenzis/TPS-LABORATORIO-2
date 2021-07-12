using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class FaroDAO:BaseDAO
    {
        public FaroDAO():base()
        {

        }      

        /// <summary>
        /// Inserta un producto a la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public bool InsertarFaroLed(FaroLed faro)
        {
            string sql = "Insert into FaroLedDetalles(nombre, medida, tipoLed, stock) " +
                "values(@auxNombre, @auxMedida, @auxTipoLed, @auxStock)";

            
            Comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            Comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida.ToString()));
            Comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));
            Comando.Parameters.Add(new SqlParameter("@auxTipoLed", faro.TipoLed.ToString()));

            return EjecutarNonQuery(sql);
        }

        /// <summary>
        /// Inserta un producto a la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public bool InsertarFaroLampara(FaroLampara faro)
        {
            string sql = "Insert into FaroDetalles(nombre, medida, stock) " +
                "values(@auxNombre, @auxMedida, @auxStock)";


            Comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            Comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida.ToString()));
            Comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));

            return EjecutarNonQuery(sql);
        }

        /// <summary>
        /// Modifica un producto de la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>True si se modifico, false caso contrario</returns>
        public bool ModificarFaro(Faro faro)
        {
            string sql = "Insert into FaroDetalles(nombre, medida, tipo, stock) " +
               "values(@auxNombre, @auxMedida, @auxStock)";

            Comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            Comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida.ToString()));
            Comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));

            return EjecutarNonQuery(sql);
        }


        




        /// <summary>
        /// Elimina un producto de la base de datos
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>true si se elimino, false caso contrario</returns>
        public bool EliminarFaro(Faro faro)
        {
            string sql = "Delete FaroDetalles where id = @auxID";

            Comando.Parameters.Add(new SqlParameter("@auxID", faro.Id));

            return EjecutarNonQuery(sql);
        }


        public List<FaroLampara> LeerLampara()
        {
            List<FaroLampara> productos = new List<FaroLampara>();

            try
            {
                Comando.CommandText = "Select * from FaroDetalles";

                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();

                    productos.Add(new FaroLampara(int.Parse(reader["id"].ToString()), reader["nombre"].ToString(),
                    (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString())));

                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw new ArchivoException("Falla al intentar leer la base de datos", e);

            }
            finally
            {
                Conexion.Close();
            }

            return productos;
        }

        public List<FaroLed> LeerLeds()
        {
            List<FaroLed> productos = new List<FaroLed>();

            try
            {
                Comando.CommandText = "Select * from FaroLedDetalles";

                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new FaroLed(int.Parse(reader["id"].ToString()), reader["nombre"].ToString(),
                    (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString()), (FaroLed.ETipoLed)(reader["tipoLed"])));

                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw new ArchivoException("Falla al intentar leer la base de datos", e);

            }
            finally
            {
                Conexion.Close();
            }

            return productos;
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
                Comando.CommandText = "Select * from FaroDetalles";

                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();

                    if (tipo == "lámpara")
                    {
                        productos.Add(new FaroLampara(int.Parse(reader["idProducto"].ToString()), reader["descripcion"].ToString(),
                        (Faro.EMedida)(reader["medida"]), int.Parse(reader["stock"].ToString())));

                    }
                    else if (tipo== "led")
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
                Conexion.Close();
            }

            return productos;
        }

        

        /// <summary>
        /// Trae un producto de la base de datos identificado con el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de tipo producto</returns>
        public string GetStockLampara()
        {
            string total=String.Empty;
            try
            {
                Comando.CommandText = "SELECT SUM (stock) AS suma FROM FaroDetalles ";

                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    total = reader["suma"].ToString();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new ArchivoException("Falla al intentar leer la base de datos", e);
            }
            finally
            {
                Conexion.Close();
            }
            if (int.Parse(total) > 0)
                return $"El stock total es de {total}";

            else
                return "No hay stock";
        }

        /// <summary>
        /// Trae un producto de la base de datos identificado con el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de tipo producto</returns>
        public string GetStockLed()
        {
            string total = String.Empty;
            try
            {
                Comando.CommandText = "SELECT SUM (stock) AS suma FROM FaroLedDetalles ";

                Conexion.Open();

                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    total = reader["suma"].ToString();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new ArchivoException("Falla al intentar leer la base de datos", e);
            }
            finally
            {
                Conexion.Close();
            }

            if (int.Parse(total) > 0)
                return $"El stock total es de {total}";

            else
                return "No hay stock";
        }


    }
}