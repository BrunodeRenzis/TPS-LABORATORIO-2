using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instansiables
{
    public class Profesor:Universitario
    {
        Queue<Universidad.EClases> clasesDelDia= new Queue <Universidad.EClases>();
        static Random random;

        #region Constructores
        public Profesor():base()
        {

        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad,id)
        {
            this._randomClases();
        }
        #endregion

        #region Métodos
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASES DEL DIA: ");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }

        private void _randomClases()
        {
            for(int i=0;i<2;i++)
            {
                int clase = random.Next(0, 3);

                switch (clase)
                {
                    case 0:
                        clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 1:
                        clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 2:
                        clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 3:
                        clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;

                }

            }
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator == (Profesor i,Universidad.EClases clase)
        {
            foreach (Universidad.EClases clases in i.clasesDelDia)
            {
                if(clases == clase)
                    return true;
            }
            return false;
        }

        public static bool operator != (Profesor i, Universidad.EClases clase)
        {
            return !(i==clase);
        }
        

        #endregion


    }
}
