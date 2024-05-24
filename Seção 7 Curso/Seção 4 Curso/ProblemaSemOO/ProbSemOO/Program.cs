using System;
using System.Globalization;

namespace ProbSemOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre Com Medidas X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre Com Medidas Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Area De X:"+ areax.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y:"+ areay.ToString("f4", CultureInfo.InvariantCulture));

            if (areax>areay)
            {
                Console.WriteLine("Maior Área = X");
            }
            else
            {
                Console.WriteLine("Maior Área = Y");
            }
        }
    }
}