using System;
using System.Globalization;

namespace exerentrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre Com Seu Nome Completo: ");
            string b = Console.ReadLine();
            
            Console.WriteLine("Quantos Quartos Tem Na Sua Casa? ");
            int qt = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre Com o Preço de Um Produto: ");
            double pr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre Seu Último Nome, Idade e Altura:");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Seu Nome Completo: "+b);
            Console.WriteLine("Quartos: "+qt);
            Console.WriteLine("Preço: "+ pr.ToString("F2", CultureInfo.InvariantCulture)); // vai mostrar 2 casa decimal
            Console.WriteLine("Último Nome: "+p1);
            Console.WriteLine("Idade: "+p2);
            Console.WriteLine("Altura: "+p3);
        }
    }
}
