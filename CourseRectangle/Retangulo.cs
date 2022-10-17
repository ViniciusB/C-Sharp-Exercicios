using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CourseRectangle
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return largura * 2 + altura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
