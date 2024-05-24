using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
// Aula 9 - Seção 6 
namespace ExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Quantos Quartos Serão Alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("quartos ocupado:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ":" + vet[i]);
                }
            }

        }
    }
}