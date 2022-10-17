using System;
using System.Globalization;

namespace CourseRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo valor = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            valor.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(valor);
        }
    }
}
