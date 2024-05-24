using System;

namespace Entdados1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Seu Nome: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Você Digitou: "+frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();

            Console.WriteLine("Vetor: ");
            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou: " + p1 +", "+ p2 +", "+ p3);

        }
    }
}
