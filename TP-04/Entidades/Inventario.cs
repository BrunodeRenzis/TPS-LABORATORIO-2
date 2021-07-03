using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Inventario
    {
        static double tornillos;
        static double bulones;
        static double arandelas;
        static double tuercas;
        static double lentes;

        public static double Tornillos { get => tornillos; set => tornillos = value; }
        public static double Bulones { get => bulones; set => bulones = value; }
        public static double Arandelas { get => arandelas; set => arandelas = value; }
        public static double Tuercas { get => tuercas; set => tuercas = value; }
        public static double Lentes { get => lentes; set => lentes = value; }

        public static bool GuardarStock(List<Inventario> lista)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "stock.xml");
            Xml<List<Inventario>> inv = new Xml<List<Inventario>>();

            return inv.Guardar(path, lista);
        }

        /*
         
                 public bool DescontarArandelas(Faro faro)
        {
            string sql = $" UPDATE Stock SET arandelas = (arandelas - @auxArandelas) WHERE arandelas>0";

            comando.Parameters.Add(new SqlParameter("@auxArandelas", faro.Arandelas));
            
            return EjecutarNonQuery(sql);
        }
        public bool DescontarBulones(Faro faro)
        {
            string sql = $" UPDATE Stock SET bulones = (bulones - @auxBulones) WHERE bulones>0";

            comando.Parameters.Add(new SqlParameter("@auxBulones", faro.Bulones));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarLentes(Faro faro)
        {
            string sql = $" UPDATE Stock SET lentes = (lentes - @auxLentes) WHERE lentes>0";

            comando.Parameters.Add(new SqlParameter("@auxLentes", faro.Lentes));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarTornillos(Faro faro)
        {
            string sql = $" UPDATE Stock SET tornillos = (tornillos - @auxTornillos) WHERE tornillos>0";

            comando.Parameters.Add(new SqlParameter("@auxTornillos", faro.Tornillos));

            return EjecutarNonQuery(sql);
        }

        public bool DescontarTuercas(Faro faro)
        {
            string sql = $" UPDATE Stock SET tuercas = (tuercas - @auxTuercas) WHERE tuercas>0";

            comando.Parameters.Add(new SqlParameter("@auxTuercas", faro.Tuercas));

            return EjecutarNonQuery(sql);
        }
         
         
         */
    }
}
