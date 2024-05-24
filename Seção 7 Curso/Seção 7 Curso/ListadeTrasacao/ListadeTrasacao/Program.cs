using System;
using System.Collections.Generic;
namespace ListadeTrasacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o saldo inicial:");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de transações:");
            int quantidadeTransacoes = Convert.ToInt32(Console.ReadLine());
            int numeroTransacao = 1;
            List<string> transacoes = new List<string>();

            for (int i = 0; i < quantidadeTransacoes; i++)
            {
                Console.WriteLine("Informe o tipo de transação (D para depósito, S para saque):");
                string tipoTransacao = Console.ReadLine();
                Console.WriteLine("Informe o valor da transação:");
                double valorTransacao = Convert.ToDouble(Console.ReadLine());

                if (tipoTransacao == "D" || tipoTransacao == "d")
                {
                    saldo += valorTransacao;
                    transacoes.Add(numeroTransacao + ". Depósito de " + valorTransacao);
                    numeroTransacao++;
                }
                else if (tipoTransacao == "S" || tipoTransacao == "s")
                {
                    saldo -= valorTransacao;
                    transacoes.Add(numeroTransacao + ". Saque de " + valorTransacao);
                    numeroTransacao++;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Utilize D para depósito ou S para saque.");
                    i--;
                }
            }

            Console.WriteLine("\nSaldo: " + saldo);
            Console.WriteLine("\nTransações:");

            foreach (string t in transacoes)
            {
                Console.WriteLine(t);
            }
        }
    }
}