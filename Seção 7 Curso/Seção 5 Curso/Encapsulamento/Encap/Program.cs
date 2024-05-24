using System;
using System.Globalization;

namespace Encap /* E Propertie */
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1200.00, 10);
             
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(p.Quantidade);

            Console.WriteLine("Total " + (p.Preco * p.Quantidade).ToString(CultureInfo.InvariantCulture));
        }
    }
}