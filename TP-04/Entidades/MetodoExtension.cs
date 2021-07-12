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
        public static string AveriguarStockTotalLampara(this string t)
        {
            FaroDAO faro = new FaroDAO();
            t=faro.GetStockLampara();
            return t;
        }

        public static string AveriguarStockTotalLed(this string t)
        {
            FaroDAO faro = new FaroDAO();
            t = faro.GetStockLed();
            return t;
        }

    }
}
