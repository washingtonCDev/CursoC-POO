using System;
using System.Globalization;
namespace ExerPROP
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 5);

            p.Nome = "LG Tv 4K55";
            p.Preco = (560.00);
            p.Preco = (6);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.value);

        }
    }
}