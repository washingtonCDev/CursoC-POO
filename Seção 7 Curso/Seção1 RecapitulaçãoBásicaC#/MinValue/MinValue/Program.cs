using System;

namespace MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.MinValue; //Valor Minimo Do int
            int n2 = int.MaxValue; //Valor Máximo 
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;
            int n5 = 45;  

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            
            int m7 = Console.Read();
        }
    }
}