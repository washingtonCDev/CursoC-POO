using System;
// Aula 6 - Seção 6
namespace GarbageCollector
{// y = 20 é apagado da memoria quando o escopo dele termina{int y = 20} <- no caso
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            if (x > 0)
            {
                int y = 20;
            }
            Console.WriteLine(x);
        }
    }
}