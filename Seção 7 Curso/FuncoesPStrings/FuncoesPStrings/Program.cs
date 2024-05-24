using System;
namespace FuncoesPStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = " abc DEF GHI abc DEF ";

            int tam = original.Length; // Ver o tamanho do String todo e (contando os espaços)
            int tam2 = original.Trim().Replace(" ", " ").Length; //substituir espaço vazio por nada
            string s1 = original.ToUpper(); // Grande
            string s2 = original.ToLower(); // Pequeno
            string s3 = original.Trim(); // Remove espaços em branco
            int p1 = original.IndexOf("bc"); // procura o bc dentro da string
            int p2 = original.LastIndexOf("bc"); // procura os ultimos bc dentro da string
            string s4 = original.Substring(3); // Recortar - Ver o caractere desta posição adiante
            string s5 = original.Substring(3, 5); // Recortar - de TAL posição até TAL


            Console.WriteLine("Tamanho do String" + tam);
            Console.WriteLine("Tamanho sem espaços" + tam2);
            Console.WriteLine("original: " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine("Trim:" + s3);
            Console.WriteLine("IndexOf('bc'): " + p1);
            Console.WriteLine("LastIndexOf('bc'): " + p2);
            Console.WriteLine("substring(3)" + s4);
            Console.WriteLine("substring(3, 5)" + s5);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}