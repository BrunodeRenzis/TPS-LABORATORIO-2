using System;

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
                    rtn = "+";
                    break;
            }

            return rtn;

        }

        public static double Operar(Operando num1, Operando num2, string operador)
        {
            double result = 0;
            string opr="+";

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
