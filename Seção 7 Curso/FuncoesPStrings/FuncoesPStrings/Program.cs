using System;
namespace FuncoesPStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = " abc DEF GHI abc DEF ";

            int tam = original.Length; // Ver o tamanho do String todo e (contando os espaços)
            int tam2 = original.Trim().Replace(" ", " ").Length; //REPLACE substituir espaço vazio por nada
            int p1 = original.IndexOf("bc"); // procura o bc dentro da string
            int p2 = original.LastIndexOf("bc"); // procura os ultimos bc dentro da string
            string s1 = original.ToUpper(); // Grande
            string s2 = original.ToLower(); // Pequeno
            string s3 = original.Trim(); // Remove espaços em branco
            string s4 = original.Substring(3); // Recortar - Ver o caractere desta posição adiante
            string s5 = original.Substring(3, 5); // Recortar - de TAL a quantia depois do Especificado
            string s6 = original.Replace('a','x'); // Susbstitui todos A por X no case CHAR
            string s7 = original.Replace("abc","OLÁ"); // Susbstitu string por string

            bool s8 = string.IsNullOrEmpty(original); // Testar se é vazio
            bool s9 = string.IsNullOrWhiteSpace(original); // Testa se é um monte de espaço em branco

            Console.WriteLine("original: " + original);
            Console.WriteLine("Tamanho do String" + tam);
            Console.WriteLine("Tamanho sem espaços" + tam2);
            Console.WriteLine("IndexOf('bc'): " + p1);
            Console.WriteLine("LastIndexOf('bc'): " + p2);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine("Trim:" + s3);
            Console.WriteLine("substring(3)" + s4);
            Console.WriteLine("substring(3, 5)" + s5);
            Console.WriteLine("Replace('a','x'): " + s6);
            Console.WriteLine("Replace(Abc,OLÁ): " + s7);

            Console.WriteLine("IsNullOrEmpty "+ s8);
            Console.WriteLine("IsNullOrWhiteSpace " + s9);
            Console.WriteLine();
            if (string.IsNullOrEmpty(original) == false )
            {
                Console.WriteLine("Formulário não deve ser Vazio");
            }
            else
            {
                Console.WriteLine("Tudo Certo");
            }
        }
    }
}