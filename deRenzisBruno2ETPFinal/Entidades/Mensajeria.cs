using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensajeria
    {
        Empleado empleado;

    }

    public enum EEstado
    {
        EnViaje=0,
        Entregado=1,
        NoEntregado=-1
    }
}
