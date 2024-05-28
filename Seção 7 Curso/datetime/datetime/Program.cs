using System;
using System.Globalization;
namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Day);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.TimeOfDay);
            Console.WriteLine(d1.DayOfWeek);

            Data data = new Data();

            data.Date(10, 05, 2005);
            Console.WriteLine($"{data.Day}/{data.Month:d2}/{data.Year:d2}");
            Console.WriteLine();
            DateTime d2 = new DateTime(2012, 11, 21, 20, 39, 3, 500);
            Console.WriteLine(d2);
            DateTime d3 = DateTime.UtcNow;
            Console.WriteLine(d3);
            Console.WriteLine();

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("10/07/2023 12:21:52");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine();
            DateTime d6 = DateTime.ParseExact("2000-08-31", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d6);
            DateTime d7 = DateTime.ParseExact("2002/01/29 13:05:58", "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            // ParseExact na web mostra varios exemplos de mascara de formatação como este // 
            Console.WriteLine(d7); Console.WriteLine(); Console.WriteLine();

            DateTime t = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime t1 = t.AddDays(2); // adiciona 2 dias /
            Console.WriteLine(t);
            Console.WriteLine(t1);

            TimeSpan a = t.Subtract(t1);
            Console.WriteLine(a);// vai mostrar quantos dias foram subtraidos //
            Console.WriteLine(t);

        }
    }
}