using System;
using System.Globalization;

namespace saidadedados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char gen = 'F';
            int idade = 32;
            double saldo = 10200.3459;
            string nome = "Maria";

            Console.WriteLine("Olá!!");
            Console.WriteLine(gen);
            Console.WriteLine(idade);
            Console.WriteLine(nome);

            Console.WriteLine("--------------");
            Console.WriteLine(saldo.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString("f4", CultureInfo.InvariantCulture));
            // Placeholders //
            Console.WriteLine("{0} Tem {1} anos e tem {2:f2} Reais", nome, idade, saldo);
            // Interpolação //
            Console.WriteLine($"{nome} Tem {idade} anos e tem {saldo:f2} Reais");
            // Concatenação //
            Console.WriteLine(nome + "tem" +idade+ "anos e saldo de " +saldo.ToString("f2")+ " reais");
        }
    }
}