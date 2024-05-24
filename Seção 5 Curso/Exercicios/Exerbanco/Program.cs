using System;
namespace Exer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            produto x;
            x = new produto();

            x.AdValor(569.00);
            x.AdNome("mateus");

            Console.Write("Digite o Numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            int? numeroProduto = x.AdNumero(numeroConta);
            if (numeroProduto.HasValue)
            {
                Console.WriteLine("Nome Da Conta: " + x.Nome);
                Console.WriteLine("Saldo: " + x.Valor);
            }
            else
            {
                Console.WriteLine("Número de conta inválido!");
            }
        }
    }
}