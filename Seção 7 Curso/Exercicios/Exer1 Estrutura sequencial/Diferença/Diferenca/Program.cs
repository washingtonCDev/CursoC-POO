using System;

// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D) //

namespace Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Quatro Valores inteiros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = (a*b - c*d);
            Console.WriteLine($"DIFERENÇA = {dif}");
        }
    }
}
