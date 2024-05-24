using System;
using System.Collections.Generic;
namespace ListaPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Ventura");
            list.Add("Carla");
            list.Add("Alex");
            list.Add("Almara");
            list.Add("Maira");
            list.Add("Fabiano");
            list.Add("Alvaro");
            list.Insert(2, "Fabiano");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count " + list.Count);
            Console.WriteLine("Capacidade da Lista: " + list.Capacity);

            Console.WriteLine();
            string objsecond = list[0] + " " + list[1];
            Console.WriteLine("Primeiro e segundo: " + objsecond);

            string filt = list.Find(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("Primeira Inicia Com 'A': " + filt);

            string filt1 = list.FindLast(x => x.StartsWith("A") || x.StartsWith("a"));
            Console.WriteLine("Ultima Inicia Com 'A': " + filt1);

            Console.WriteLine();

            string filtEnd1 = list.Find(x => x.EndsWith("A") || x.EndsWith("a"));
            Console.WriteLine("Primeiro Termina Com 'A': " + filtEnd1);

            string filtEnd = list.FindLast(x => x.EndsWith("A") || x.EndsWith("a"));
            Console.WriteLine("Ultimo Termina Com 'A': " + filtEnd);
            Console.WriteLine();

            List<string> filt2 = list.FindAll(x => x[0] == 'A' || x[0] == 'a');
            Console.WriteLine("Todos Iniciam Com 'A': ");
            foreach (string names in filt2)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine();

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posicao Inicia Com A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ulitma Posicao Inicia Com A: " + pos2);

            Console.WriteLine();
            List<string> list2 = list.FindAll(x => x.Length > 5); // mostra todos com mais de 5 caracteres
            Console.WriteLine("Todos Com 5 Caracteres: ");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("remove alex"); // remove apenas alex no caso
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("removerange");
            list.RemoveRange(2, 2); // Apartir da pose2 Remove 2 elementos no caso
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------"); // Remove todos iniciam com M no caso
            Console.WriteLine("removeall M");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------"); // remove na posição 2 no caso
            Console.WriteLine("removeat2");
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}