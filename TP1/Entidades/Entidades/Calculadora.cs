using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado=0;
            
            ValidadOperador(operador);

            switch (operador)
            {
                case "+":
                    resultado = (num1 + num2);
                    break;

                case "-":
                    resultado = (num1 - num2);
                    break;

                case "*":
                    resultado = (num1 * num2);
                    break;

                case "/":
                    resultado = (num1 / num2);
                    break;
            }
            return resultado;
        }

        private static string ValidadOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                operador="+";
            
            return operador;    
        }


    }
}
