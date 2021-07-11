using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static string AveriguarStockTotal(this string t)
        {
            FaroDAO faro = new FaroDAO();
            t=faro.GetStock();
            return t; 
        }

        

    }
}
