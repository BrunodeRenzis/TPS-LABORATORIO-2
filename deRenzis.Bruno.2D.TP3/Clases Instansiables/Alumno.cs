using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instansiables
{
    public sealed class Alumno : Universitario
    {
        EEstadoCuenta estadoCuenta;
        Universidad.EClases claseQueToma;
        
         
        #region Constructores
        public Alumno():base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma): base(nombre,apellido,dni,nacionalidad,id)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        


        #endregion

        #region Métodos

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Estado de cuenta: {this.estadoCuenta}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            return String.Format($"Clase que toma: {this.claseQueToma}");
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Enumerado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator==(Alumno a,Universidad.EClases clase)
        {
            if(a.estadoCuenta!= EEstadoCuenta.Deudor && a.claseQueToma == clase)
            {
                return true;
            }
            
            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma!=clase)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
