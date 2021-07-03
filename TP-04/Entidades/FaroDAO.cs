﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Consultas andando en la base
/*
   SELECT * FROM Stock;

  UPDATE Stock SET arandelas = 100; 

  UPDATE Stock SET arandelas = (arandelas - 10) WHERE arandelas>0;
  
  SELECT SUM (stock) FROM FaroDetalles WHERE tipo='Led';

  SELECT SUM (stock) FROM FaroDetalles WHERE tipo='Lámpara';
 */





namespace Entidades
{
    public class FaroDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private delegate bool DescontarMateriales(Faro faro);
       
       
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
                throw new ArchivoException("Fallo al intentar conectar a base de datos", e);
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
            string sql = "Insert into FaroDetalles(nombre, medida, tipo, stock) " +
                "values(@auxNombre, @auxMedida, @auxTipo, @auxStock)";

            
            comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));
            comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

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
               "values(@auxNombre, @auxMedida, @auxTipo, @auxStock)";

            comando.Parameters.Add(new SqlParameter("@auxNombre", faro.Nombre));
            comando.Parameters.Add(new SqlParameter("@auxMedida", faro.Medida.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxStock", faro.Stock));
            comando.Parameters.Add(new SqlParameter("@auxTipo", faro.Tipo.ToString()));

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
                comando.CommandText = "Select * from FaroDetalles";

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
                conexion.Close();
            }

            return productos;
        }

        /// <summary>
        /// Trae un producto de la base de datos identificado con el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de tipo producto</returns>
        public string GetStock()
        {
            string total=String.Empty;
            try
            {
                comando.CommandText = "SELECT SUM (stock) FROM FaroDetalles AS suma";

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    total = reader["suma"].ToString();
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

              return $"El stock total es de {total}";
        }
    }
}