using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public double SetNumero
        {
            set {this.numero = ValidarNumero(value.ToString());}

        }
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";
            double acumulador = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        acumulador += Math.Pow(2, i);
                    }
                }
                resultado = acumulador.ToString();
            }
            return resultado;
        }

        public string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroEntero = (int)numero;

            if (numeroEntero > 0)
            {
                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }
                    numeroEntero = numeroEntero / 2;
                }
            }
            else
            {
                if (numeroEntero == 0)
                {
                    resultado = "0";
                }
                else
                {
                    resultado = "Valor invalido";
                }
            }
            return resultado;
        }

        public string DecimalBinario(string numero)
        {
            string resultado = "Valor invalido";
            double aux;

            if (double.TryParse(numero, out aux))
            {
                resultado = DecimalBinario(aux);
            }

            return resultado;
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }

        public static double operator + (Numero num1, Numero num2)
        {
            return (num1.numero + num2.numero);
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return (num1.numero - num2.numero);
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return (num1.numero * num2.numero);
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;
            else
                return (num1.numero / num2.numero);
        }

        private double ValidarNumero (string strNumero)
        {
            double numAux;
            if(!double.TryParse(strNumero,out numAux))
                numAux=0;

                return numAux;
        }

        private bool EsBinario(string binario)
        {
            bool esBinario = false;
            for(int i=0;i<binario.Length;i++)
            {
                if(binario[i] == '0' || binario[i]== '1')
                    esBinario = true;             
                else
                    break;
            }
            return esBinario;
        }
    }
}
