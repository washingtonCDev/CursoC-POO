using System;

namespace estifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre Com Um Número: ");

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}