using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Persona
    {
        int idEmpleado;
        bool empleadoActivo;
        public Vendedor(string nombre, string apellido, int dni, int edad, string sexo, int idEmpleado) : base(nombre, apellido, dni, edad, sexo)
        {
            this.IdEmpleado = idEmpleado;
            this.EmpleadoActivo = false;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public bool EmpleadoActivo { get => empleadoActivo; set => empleadoActivo = value; }
    }
}
