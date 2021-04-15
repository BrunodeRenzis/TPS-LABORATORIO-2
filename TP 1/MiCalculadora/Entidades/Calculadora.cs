using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string rtn = "+";

            switch (operador)
            {
                case "-":
                    rtn = "-";
                    break;
                case "*":
                    rtn = "*";
                    break;
                case "/":
                    rtn = "/";
                    break;
                default:
                    break;
            }

            return rtn;

        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result=0;
            string opr;

            opr = ValidarOperador(operador);

            switch (opr)
            {
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":                                        
                    result = num1 / num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                default:
                    break;
            }

            return result;

        }
    }
}
