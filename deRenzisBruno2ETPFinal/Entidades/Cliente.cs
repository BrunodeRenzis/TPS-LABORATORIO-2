using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Cliente:Persona
    {
        int idCliente;
        string direccion;
        public Cliente():base()
        {
        }

        public Cliente(string nombre, string apellido, string dni, string cuil, ESexo sexo, string direccion,int idCliente):base(idCliente,nombre, apellido, dni, cuil, sexo)
        {
            this.idCliente = idCliente;

        }
    }
}
