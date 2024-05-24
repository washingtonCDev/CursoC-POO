using System;
using System.Globalization;

namespace NomeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NomSalario f1 = new NomSalario();
            NomSalario f2 = new NomSalario();

            Console.WriteLine("Dados do Funcionário 1: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Funcionário 2: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Média De Salários: " + Media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}