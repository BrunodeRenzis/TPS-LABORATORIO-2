using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockDAO:BaseDAO
    {
        public StockDAO():base()
        {

        }

        public void SelectMateriales()
        {
            string sql = "SELECT * FROM Stock";
            Comando.CommandText = sql;
            try
            {
                Conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Inventario.Arandelas = int.Parse(reader["arandelas"].ToString());
                    Inventario.Bulones = int.Parse(reader["bulones"].ToString());
                    Inventario.Lentes = int.Parse(reader["lentes"].ToString());
                    Inventario.Tornillos = int.Parse(reader["tornillos"].ToString());
                    Inventario.Tuercas = int.Parse(reader["tuercas"].ToString());
                }
                reader.Close();
            }

            catch(Exception ex)
            {
                Console.WriteLine("No se puede generar los elementos",ex);
            }

            finally
            {
                Conexion.Close(); 
            }
        }

        public bool InicializarStockArandelas()
        {
            string sql = $" UPDATE Stock SET arandelas = (@auxArandelas)";
            
            Comando.Parameters.Add(new SqlParameter("@auxArandelas", 100));

            return EjecutarNonQuery(sql);
        }

        public bool InicializarStockBulones()
        {
            string sql = $" UPDATE Stock SET bulones = (@auxBulones)";

            Comando.Parameters.Add(new SqlParameter("@auxBulones", 100));

            return EjecutarNonQuery(sql);
        }

        public bool InicializarStockLentes()
        {
            string sql = $" UPDATE Stock SET lentes = (@auxLentes)";

            Comando.Parameters.Add(new SqlParameter("@auxLentes", 100));

            return EjecutarNonQuery(sql);
        }

        public bool InicializarStockTornillos()
        {
            string sql = $" UPDATE Stock SET tornillos = (@auxTornillos)";

            Comando.Parameters.Add(new SqlParameter("@auxTornillos", 100));

            return EjecutarNonQuery(sql);
        }

        public bool InicializarStockTuercas()
        {
            string sql = $" UPDATE Stock SET tuercas = (@auxTuercas)";

            Comando.Parameters.Add(new SqlParameter("@auxTuercas", 100));

            return EjecutarNonQuery(sql);
        }

        public void DescontarMateriales()
        {
            string sql = $" UPDATE Stock SET arandelas = @auxArandelas,bulones = @auxBulones,lentes = @auxLentes,tornillos = @auxTornillos,tuercas = @auxTuercas";

            Comando.CommandText=sql;

            Comando.Parameters.AddWithValue("@auxArandelas", Inventario.Arandelas);
            Comando.Parameters.AddWithValue("@auxBulones", Inventario.Bulones);
            Comando.Parameters.AddWithValue("@auxLentes", Inventario.Lentes);
            Comando.Parameters.AddWithValue("@auxTornillos", Inventario.Tornillos);
            Comando.Parameters.AddWithValue("@auxTuercas", Inventario.Tuercas);

            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Conexion.Close();
            }
        }
        public bool DescontarBulones(int cantidad)
        {
            string sql = $" UPDATE Stock SET bulones = (bulones - @auxBulones) WHERE bulones>0";

            Comando.Parameters.Add(new SqlParameter("@auxBulones", cantidad));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarLentes(int cantidad)
        {
            string sql = $" UPDATE Stock SET lentes = (lentes - @auxLentes) WHERE lentes>0";

            Comando.Parameters.Add(new SqlParameter("@auxLentes", cantidad));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarTornillos(int cantidad)
        {
            string sql = $" UPDATE Stock SET tornillos = (tornillos - @auxTornillos) WHERE tornillos>0";

            Comando.Parameters.Add(new SqlParameter("@auxTornillos", cantidad));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarTuercas(int cantidad)
        {
            string sql = $" UPDATE Stock SET tuercas = (tuercas - @auxTuercas) WHERE tuercas>0";

            Comando.Parameters.Add(new SqlParameter("@auxTuercas", cantidad));

            return EjecutarNonQuery(sql);
        }
         
         
    }
}
