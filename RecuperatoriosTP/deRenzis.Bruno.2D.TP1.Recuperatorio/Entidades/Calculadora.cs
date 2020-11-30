using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación seleccionada.
        /// </summary>
        /// <param name="num1">Numero</param>
        /// <param name="num2">Numero</param>
        /// <param name="operador">String</param>
        /// <returns>Devuelve el resultado de la operación seleccionada.</returns>
        public static double Operar(Numero num1,Numero num2, char operador)
        {
            double auxResultado=0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    auxResultado = num1 + num2;
                    break;
                case "-":
                    auxResultado = num1 - num2;
                    break;
                case "*":
                    auxResultado = num1 * num2;
                    break;
                case "/":
                    auxResultado = num1 / num2;
                    break;
            }
            return auxResultado;
        }

        /// <summary>
        /// Valida el operador seleccionado
        /// </summary>
        /// <param name="operador">cha</param>
        /// <returns>Retorna el operador seleccionado, caso que no sean validos retorna +</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                return operador.ToString();
            else
                return "+";
        }

    }
}
