using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas

{
    public abstract class Universitario : Persona
    {
        int legajo;
        #region Constructores
        public Universitario():base()
        {

        }

        public Universitario(string nombre,string apellido, string dni, ENacionalidad nacionalidad, int legajo):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion
        #region Sobrecarga de operadores
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
        #region Métodos
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo {this.legajo}");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this.GetType(),obj.GetType()))
            {
                return true;
            }
            return false;
        }

        protected abstract string ParticiparEnClase();
        #endregion

    }
}
