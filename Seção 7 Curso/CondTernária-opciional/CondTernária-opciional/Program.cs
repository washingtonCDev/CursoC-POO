using System;
using System.ComponentModel;
// aula 3 - seção 7: Expressão condicional ternária
namespace CondTernária_opciional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            string id = (idade > 4) ? "verdade" : "falso";

            Console.WriteLine("idade digitada "+id);
        }
    }
}