using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        public string Numero { set { numero = ValidarOperando(value); } }

        

        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero):this()
        {
            Numero = numero.ToString();
        }

        public Operando(string numero):this()
        {
            Numero = numero;
        }

        private double ValidarOperando(string strNumero)
        {
            double aux;

            return double.TryParse(strNumero, out aux) ? aux : 0;
        }

        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != 0 || binario[i] != 1)
                    return false;
            }
            return true;
        }

        public static string DecimalBinario(double num)
        {
            string bin = "";
            string auxBin = "";
            StringBuilder aux = new StringBuilder("");
            int module = 0;
            int result = 0;

            if (num != 0 && num != 1)
            {
                result = (int)num;

                while (result / 2 != 1)
                {
                    module = result % 2;
                    result = result / 2;
                    aux.Append(module.ToString());
                }

                module = result % 2;
                result = result / 2;

                aux.Append(module.ToString());
                aux.Append(result.ToString());
                auxBin = aux.ToString();

                for (int i = auxBin.Length - 1; i >= 0; i--)
                {
                    bin += auxBin[i];
                }
            }
            else
            {
                bin = num.ToString();
            }

            return bin;
        }

        public static string DecimalBinario(string str)
        {
            string bin = "Valor invalido", newBin = "";
            double num;
            int resto, i;

            if (double.TryParse(str, out num))
            {
                num = Math.Truncate(Math.Abs(num));
                bin = DecimalBinario(num);

                if (bin.Length >= 5)
                {
                    resto = bin.Length % 4;
                    for (i = 0; i < resto; i++)
                    {
                        newBin += bin[i];
                    }

                    newBin += ' ';
                    for (int j = 0; i < bin.Length; i++, j++)
                    {
                        newBin += bin[i];
                        if (j == 3)
                        {
                            if (i != bin.Length - 1)
                            {
                                newBin += ' ';
                            }

                            j = -1;
                        }
                    }
                    bin = newBin;
                }
            }

            return bin;

        }

        public static string BinarioDecimal(string num)
        {
            double acum = 0;
            string dec = "Valor invalido";
            string bin;
            int i;

            if (num != "")
            {
                bin = num.Replace(" ", "");
                for (i = 0; i < bin.Length; i++)
                {
                    if (EsBinario(bin))
                    {
                        break;
                    }
                }

                if (i == bin.Length)
                {
                    for (int j = bin.Length - 1, exp = 0; j >= 0; j--, exp++)
                    {
                        if (bin[j] == '1')
                        {
                            acum += Math.Pow(2, exp);
                        }
                    }

                    dec = acum.ToString();
                }
            }

            return dec;
        }


        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            return n2.numero == 0 ? double.MinValue : n1.numero / n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

       
    }
}
