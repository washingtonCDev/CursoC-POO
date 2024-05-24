using System;
using System.Globalization;
// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
// hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais
namespace SalarioFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o Número do Funcionário? ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Quantas Horas de Trabalho? ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Quanto Recebe Por Hora? ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double Sal = b * c;

            Console.WriteLine($"Número = {a}");
            Console.WriteLine($"Salario = {Sal.ToString("f2", CultureInfo.InvariantCulture)}");

        }
    }
}
