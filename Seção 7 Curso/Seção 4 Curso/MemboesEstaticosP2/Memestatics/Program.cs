using System;
using System.Globalization;

 
namespace Memestatics 
{  
    internal class Program 
    {
        static void Main(string[] args) 
        {

            Console.Write("Entre com o Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculat.Circunferencia(raio);
            double volume = Calculat.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculat.Pi.ToString("f2", CultureInfo.InvariantCulture));
        } 
    } 
}