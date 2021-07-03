using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace System
{
    public static class MetodoExtension
    {
        public static string AveriguarStockTotal(this string total)
        {
            FaroDAO faro = new FaroDAO();
            total=faro.GetStock();
            return total; 
        }

    }
}
