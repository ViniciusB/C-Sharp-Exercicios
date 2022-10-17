using System;
using System.Globalization;

namespace CotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double comprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double valorReais = ConversorDeMoeda.ValorEmReais(dolar, comprado);
            Console.WriteLine("Valor a ser pago em reais = {0}", valorReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
