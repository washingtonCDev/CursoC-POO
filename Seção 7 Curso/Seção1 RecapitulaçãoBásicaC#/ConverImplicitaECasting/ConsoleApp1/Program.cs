using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão implicita //
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            // Casting //
            double a;
            int b;
            a = 5.1; // perdemos informação 5.1 para 5//
            b =(int) a;
            Console.WriteLine(b);

            //kid//
            int aa = 5;
            int bb = 2;

            double resultado = (double)aa / bb;

            Console.WriteLine(resultado);


        }
    }
}