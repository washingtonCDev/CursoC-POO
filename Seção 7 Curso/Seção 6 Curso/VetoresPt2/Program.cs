using System;
using System.Globalization;
// aula 8 - seção 6 
namespace VetoresPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Preços Seram Digitados? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("NOME:" );
                string name = Console.ReadLine();
                Console.WriteLine("PREÇO:" );
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                vet[i] = new Produto { Name = name, Price = price};
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }

            double med = soma / n;
            Console.WriteLine("Media Preço: " + med.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}