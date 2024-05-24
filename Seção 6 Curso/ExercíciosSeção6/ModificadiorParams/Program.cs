using System;
// Aula 10 - Seção 6 Modificador de parâmetros: params 
namespace ModificadiorParams 
{  
    internal class Program  
    {  
        static void Main(string[] args)  
        {
            int result = Calculator.sum(10,20,30,40 );
            Console.WriteLine(result);
        }  
    }  
}  