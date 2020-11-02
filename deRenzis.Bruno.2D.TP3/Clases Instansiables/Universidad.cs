using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using Archivos;
namespace Clases_Instansiables
{
    public class Universidad
    {
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;


        #region Constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }

            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }

            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    throw new ArchivosException("índice no válido");
                }

            }

            set
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }
                else
                {
                    throw new ArchivosException("índice no válido");
                }

            }
        }
        #endregion

        #region Métodos
        public static bool Guardar(Universidad uni)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "universidad.xml");
            Xml<Universidad> universidad = new Xml<Universidad>();

            return universidad.Guardar(path, uni);
        }

        public static Universidad Leer ()
        {
            Universidad universitario = new Universidad();
            return universitario;
        }

        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }


        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alu in g.alumnos)
            {
                if(alu == a)
                {
                    return true;
                }
            }
               return false;
        }

        public static bool operator !=(Universidad g,Alumno a)
        {
            return !(g==a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (var clase in g.jornada)
            {
                if(clase.Instructor == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g,Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor unProfesor in u.Instructores)
            {
                if(unProfesor == clase)
                {
                    return unProfesor;
                }
            }
            throw new SinProfesorException("No hay profesor para la materia solicitada!");
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor unProfesor in u.profesores)
            {
                if (unProfesor != clase)
                {
                    return unProfesor;
                }
            }

            throw new SinProfesorException();
        }




        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesorDisponible = (g == clase);
            Jornada jornada = new Jornada(clase, profesorDisponible);

            foreach (Alumno a in g.alumnos)
            {
                if (a == clase)
                {
                    jornada.Alumnos.Add(a);
                }
            }

            g.jornada.Add(jornada);
            return g;
        }

        public static Universidad operator +(Universidad u,Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);

            }
            else
            {
                throw new AlumnoRepetidoException("El alumno que intenta cargar, ya fue agregado a la lista previamente");
            }

            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {

                u.profesores.Add(i);
            }

            return u;
        }

        #endregion

        #region Enumerados
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion
    }
}
