using System;
//aula 2 - seção 7: sintaxe alternativa switch case
namespace switchcase_alternativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "segunda";
                    break;
                case 2:
                    day = "terça";
                    break;
                default:
                    day = "valor inválido";
                    break;
            }
            Console.WriteLine("Dia: " + day);
        }
    }
}