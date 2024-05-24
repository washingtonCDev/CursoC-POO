using System;
using System.Globalization;
// aula 17 - Seção 6: Matrizes
namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length); // tamanho da matriz No caso 6 blocos
            Console.WriteLine(mat.Rank); // quantidade de linhas No caso 2 linhas
            Console.WriteLine(mat.GetLength(0)); /* mostra o tamnaho de cada diimensão
            no caso 2 dimensões dimensão 0 e 1  */
        } 
    } 
} 