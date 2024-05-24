using System;
using System.Globalization;
 
namespace DesalocMemoria  
{  
    internal class Program  
    { 
        static void Main(string[] args)  
        { 
            produto p1,p2;


            p1 = new produto("TV", 1500.00, 13);
            p2 = new produto("Mouse", 120.00, 25);

            Console.WriteLine("Primeiro Produto: ");
            Console.WriteLine("Nome: "+ p1.Nome);
            Console.WriteLine("preço: "+ p1.Preco.ToString());
            Console.WriteLine("Estoque: "+ p1.Quantia);
            Console.WriteLine("Valor Estoque: "+ p1.ValorEstoq());
            Console.Write("Quantia Vendida De TV: ");
            int quantiaVendas1 = int.Parse(Console.ReadLine());
            double valorVendas1 = p1.Vendas1(quantiaVendas1);
            Console.WriteLine("Valor Em Vendas: " + valorVendas1.ToString("C", CultureInfo.InvariantCulture));
            double comissao1 = valorVendas1 * 0.06;
            Console.WriteLine("Comissão do Vendedor: " + comissao1.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Em Estoque: "+ (p1.Quantia - quantiaVendas1));
            Console.WriteLine("");

            Console.WriteLine("Segundo Produto: ");
            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("preço: " + p2.Preco.ToString());
            Console.WriteLine("Estoque: " + p2.Quantia);
            Console.WriteLine("Valor Estoque: " + p2.ValorEstoq());
            Console.Write("Quantia Vendida De Mouse: ");
            int quantiaVendas2 = int.Parse(Console.ReadLine());
            double valorVendas2 = p2.Vendas2(quantiaVendas2);
            Console.WriteLine("Valor Em Vendas: "+ valorVendas2.ToString("C", CultureInfo.InvariantCulture));
            double comissao2 = valorVendas2 * 0.06;
            Console.WriteLine("Comissão do Vendedor: " + comissao2.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Em Estoque: " + (p2.Quantia - quantiaVendas2));
            Console.WriteLine("");
        }
    }  
} 