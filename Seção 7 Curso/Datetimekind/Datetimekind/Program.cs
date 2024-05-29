using System;
namespace Datetimekind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Unspecified);

            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine(d1.Kind);
            Console.WriteLine(d1.ToLocalTime()); // GMT local no caso GMT -3
            Console.WriteLine(d1.ToUniversalTime()); // GMT
            Console.WriteLine();

            Console.WriteLine(d2.Kind);
            Console.WriteLine(d2.ToLocalTime()); // GMT local no caso GMT -3
            Console.WriteLine(d2.ToUniversalTime()); // GMT
            Console.WriteLine();

            Console.WriteLine(d3.Kind); // neste caso é Não especificado, ele subtrai e soma quando chamado
            Console.WriteLine(d3.ToLocalTime()); // GMT local no caso GMT -3
            Console.WriteLine(d3.ToUniversalTime()); // GMT
            Console.WriteLine();


        }
    }
}