using System; 
namespace Nullabe 
{// aula 6 - Seção 6 
    internal class Program 
    {  
        static void Main(string[] args) 
        { 
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é null");
            if (y.HasValue)
            Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y é null");
        } 
    } 
} 