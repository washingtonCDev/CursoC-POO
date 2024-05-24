using System;

namespace OpdeAtribuicao{
    internal class Program{
        static void Main(string[] args){

        // forma cumulativa, acumula o anterior e faz a operação do proximo //

        int a = 10; 
        Console.WriteLine(a);
        a += 2;
        Console.WriteLine(a);
        a -= 2;
        Console.WriteLine(a);
        a *= 3;
        Console.WriteLine(a);
        a /= 2;
        Console.WriteLine(a);  
        a %= 3;
        Console.WriteLine(a);

        // += também serve para concatenação cumulativa //
        string s = "abc";
        Console.WriteLine(s);

        s += "def";
        Console.WriteLine(s);

        }
    }
}
