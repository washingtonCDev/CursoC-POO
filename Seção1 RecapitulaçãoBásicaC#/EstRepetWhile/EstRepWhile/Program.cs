using System;
using System.Globalization;

namespace EstRepWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Primeira Parte Fica Pra Fora//
            Console.Write("Digite um Número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (num >= 0.0)
            { // Esta parte Fica Repetindo //
                double raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo!"); // Mostra Depois Que o Código Terminar //
        }
    }
}