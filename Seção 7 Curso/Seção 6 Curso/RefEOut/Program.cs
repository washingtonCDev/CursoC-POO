using System;
//Aula 11 - Seção 6: Modificadores de parametros Ref e Out  
namespace RefEOut
{
    internal class Program
    {
        static void Main(string[] args)
        {// ref
            int a = 10;
            Calculato.Triple(ref a);
            Console.WriteLine(a);
        // out
            int b = 10;
            int triple1;
            Calculato.Triple1(b, out triple1);
            Console.WriteLine(triple1);
        }
    }
}