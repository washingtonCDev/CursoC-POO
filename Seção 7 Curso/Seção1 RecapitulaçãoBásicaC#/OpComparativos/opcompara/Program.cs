using System;
 
namespace opcompara 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        {
            int a = 10;
            bool p1 = a < 20;
            bool p2 = a > 10;
            bool p3 = a == 20;
            bool p4 = a == 10;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine("Digite um Número: ");
            int b = int.Parse(Console.ReadLine());

            if (b <= 0)
                Console.WriteLine("Negativo ");

            else
                Console.WriteLine("Positivo ");
        } 
    } 
} 