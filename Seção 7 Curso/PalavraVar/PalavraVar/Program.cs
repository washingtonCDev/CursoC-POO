using System;

namespace PalavraVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var igual no javascript recebe uma variavel e integra o tipo automaticamente
            var x = 10;
            var y = 'a';
            Console.WriteLine("Valor de X " + x);
            Console.WriteLine(y);
        }
    }
}