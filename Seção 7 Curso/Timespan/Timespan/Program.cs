using System;
namespace Timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t1.TotalSeconds);
            Console.WriteLine(t1.TotalMinutes);
            Console.WriteLine(t1.TotalHours);
            Console.WriteLine(t1.GetType());
            Console.WriteLine(t1.Duration());
            TimeSpan t2 = TimeSpan.FromDays(1.5); // 1 dia e meio 
            TimeSpan t3 = TimeSpan.FromHours(1.5); // 1 hora e meia
            // From nos permite isso mostrar TimeSpan From a unidade que queremos //
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1+t1);
        }
    }
}