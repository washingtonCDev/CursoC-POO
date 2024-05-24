using System;

namespace DemoFOr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos nuemros serão digitados? ");
            int a = int.Parse(Console.ReadLine());
            int soma = 0;
           
            for (int i = 1; i <= a; i++)
            {
                Console.Write($"Valor: #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}