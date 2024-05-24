using System;
//Aula 12 - Seção 6: Boxing e Unboxing 
namespace BoxingeUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {// Boxing
            int x = 20;
            object obj = x;
            Console.WriteLine(obj);

            // Unboxing 
            int y = (int)obj;
            Console.WriteLine(y);

        }
    }
}