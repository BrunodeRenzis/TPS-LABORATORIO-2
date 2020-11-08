using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private string sexo;


        public Persona(string nombre, string apellido, int dni,int edad,string sexo)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Edad = dni;
            this.Sexo = sexo;
        }

        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected int Dni { get => dni; set => dni = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected string Sexo { get => sexo; set => sexo = value; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del cliente: {this.Nombre}");
            sb.AppendLine($"Apellido del cliente: {this.Apellido}");
            sb.AppendLine($"Dni del cliente: {this.Dni}");
            sb.AppendLine($"Edad del cliente: {this.Edad}");
            sb.AppendLine($"Sexo del cliente: {this.Sexo}");
            return sb.ToString();
        }
    }
}
