using System;
using System.Globalization;
//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule emostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
namespace Calctotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"a) Área do triângulo retângulo: {((A * C) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"b) Área do círculo: {(Math.PI * Math.Pow(C, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"c) Área do trapézio: {(((A + B) * C) / 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"d) Área do quadrado: {Math.Pow(B, 2).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"e) Área do retângulo: {(A * B).ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
