using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        /// <summary>
        /// Constructor por defecto, inicaliza en 0 las instancias creadas.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        ///Constructor Constructor con parámetro 
        /// </summary>
        /// <param name="numero">double</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor con parámetro
        /// </summary>
        /// <param name="strNumero">string</param>
        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }

        /// <summary>
        /// Propiedad que valida dato y lo asigna al objeto instanciado.
        /// </summary>
        public double SetNumero
        {
            set { this.numero = ValidarNumero(value.ToString()); }
        }

        /// <summary>
        /// Verifica si el número ingresado como cadena de caracter es binario
        /// </summary>
        /// <param name="binario">string</param>
        /// <returns>true si es binario, false si no lo es</returns>
        private bool EsBinario(string binario)
        {

            int i = 0;
            do
            {
                if (binario[i] == '1' || binario[i] == '0')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } while (i < binario.Length);
        }

        /// <summary>
        /// Convierte un número de binario a decimal
        /// </summary>
        /// <param name="binario">string</param>
        /// <returns>Retorna el valor convertido a decimal en formato string, si no es posible la conversión devolverá "valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor inválido";
            double acumulador = 0;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i]=='1')
                    {
                        if (i == 0)
                        {
                            acumulador += 1;
                        }
                        else
                        {
                            acumulador += (int)Math.Pow(2, i);
                        }
                    }
                }
                resultado = acumulador.ToString();
            }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero">double</param>
        /// <returns>Retorna el valor convertido a binario en formato double, si no es posible la conversión devolverá "valor inválido"</returns>
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
                    resultado = "Valor inválido";
                }
            }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero">string</param>
        /// <returns>Retorna el valor convertido a binario en formato string, si no es posible la conversión devolverá "valor inválido"</returns>
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

        /// <summary>
        /// Ingresa un string y valida que corresponda a caracteres numéricos.
        /// </summary>
        /// <param name="strNumero">string</param>
        /// <returns>retorna el número convertido en double</returns>
        private double ValidarNumero(string strNumero)
        {
            double numAux;
            if (!double.TryParse(strNumero, out numAux))
                numAux = 0;

            return numAux;
        }

        /// <summary>
        /// Sobrecarga operador + 
        /// </summary>
        /// <param name="n1">Numero</param>
        /// <param name="n2">Numero</param>
        /// <returns>devuelve la suma de 2 objetos de la clase numero</returns>
        public static double operator + (Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Sobrecarga operador - 
        /// </summary>
        /// <param name="n1">Numero</param>
        /// <param name="n2">Numero</param>
        /// <returns>devuelve la resta de 2 objetos de la clase numero</returns>
        public static double operator - (Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Sobrecarga operador * 
        /// </summary>
        /// <param name="n1">Numero</param>
        /// <param name="n2">Numero</param>
        /// <returns>devuelve la multiplicación de 2 objetos de la clase numero</returns>
        public static double operator * (Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// Sobrecarga operador /
        /// </summary>
        /// <param name="n1">Numero</param>
        /// <param name="n2">Numero</param>
        /// <returns>devuelve la división de 2 objetos de la clase numero</returns>
        public static double operator / (Numero n1, Numero n2)
        {
            if (n2.numero != 0)
                return (n1.numero / n2.numero);

            else
                return double.MinValue;
        }



    }
}
