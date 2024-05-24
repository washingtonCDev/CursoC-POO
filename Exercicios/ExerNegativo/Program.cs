using System; 
 
namespace ExerNegativo 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("escreva um num:");  
            int a = int.Parse(Console.ReadLine()); 
 
            if (a <= 0)
                Console.WriteLine("Negativo");
                
            else
                Console.WriteLine("Não Negativo");

        } 
    } 
}