using System;
 
namespace Exercoa 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        {
            ClassPessoas x;

            x = new ClassPessoas();

            Console.WriteLine("Nome Da Primeira Pessoa: ");
            Console.Write("NOME: ");
            string Nome1 = Console.ReadLine();
            Console.Write("IDADE: ");
            x.Idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados Da Segunda Pessoa: ");
            Console.Write("NOME: ");
            string Nome2 = Console.ReadLine();
            Console.Write("IDADE: ");
            x.Idade2 = int.Parse(Console.ReadLine());

            if (x.Idade1 > x.Idade2)
            {
                Console.WriteLine($"Pessoa Mais Velha: {Nome1}");
            }
            else
            {
                Console.WriteLine($"Pessoa Mais Velha: {Nome2}");
            }
        }
    }
}