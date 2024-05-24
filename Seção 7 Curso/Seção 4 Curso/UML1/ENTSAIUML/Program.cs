using System;
using System.Globalization;

namespace ENTSAIUML 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Produto x; 
            x = new Produto(); 
             
            Console.WriteLine("Entre Os Dados Do Produto:"); 
            Console.Write("Nome: "); 
            x.Nome = Console.ReadLine(); 
            Console.Write("Preço: "); 
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.Write("Quantidade No Estoque: "); 
            x.Quantia = int.Parse(Console.ReadLine()); 
             
            Console.WriteLine("Dados do Produto:"+ x); 
             
            Console.WriteLine(); 
            Console.Write("Digite o numero de produtos a ser adicionado no Estoque: "); 
            int qte = int.Parse(Console.ReadLine());  
            x.AdicionarProduto(qte);
            Console.WriteLine("Dados Atualizados: "+ x);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            x.RemoverProduto(qte);
            Console.WriteLine("Dados Atualizados: " + x);


        } 
    } 
} 