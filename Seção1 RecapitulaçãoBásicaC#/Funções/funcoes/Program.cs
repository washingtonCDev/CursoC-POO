using System;

namespace funcoes 
{ 
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Três Números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + result);
        }

        static int Maior(int a, int b, int c) //função//
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}