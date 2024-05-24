using System;
using System.Globalization;

// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
// casas decimais. EX:
// Fórmula da área: area = π.raio2
// Considere o valor de π = 3.14159

namespace Raio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;

            Console.WriteLine("Digite o Raio Do Círculo:");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
