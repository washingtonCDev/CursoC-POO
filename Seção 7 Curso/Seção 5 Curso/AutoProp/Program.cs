using System;
namespace ExerPROP  // exercicio conta bancaria Código alternativo Criado Washington//
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("numero da conta: ");
            p.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com titular da conta: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Haverá Deposito inicial (s/n)? ");
            p.Resposta1 = char.Parse(Console.ReadLine());

            if (p.Resposta1 == 's' || p.Resposta1 == 'S')
            {
                Console.WriteLine("Qual valor do Depósito: ");
                p.Deposito = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Haverá Saque inicial (s/n)? ");
            p.Resposta2 = char.Parse(Console.ReadLine());
            
            if (p.Resposta2 == 's' || p.Resposta2 == 'S')
            {
                Console.WriteLine("Qual valor do saque? ");
                p.Saque = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            {
                Console.WriteLine("valor em conta: " + p);
            }
        }
    }
}
