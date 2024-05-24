using System;
// Aula 13 - Seção 6: Sintaxe Opcional: Laço Foreach
namespace Laco_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //foreach
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            
            //for Convencional
            for (int i=0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}