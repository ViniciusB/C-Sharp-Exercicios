using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    public class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double ValorEmReais(double dolar, double comprado)
        {
            return (dolar * comprado) + (dolar * comprado * Iof); 
        }

    }
}
