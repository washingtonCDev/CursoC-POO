using System;

namespace tipsreferenciavalor
{
    internal class Program
    {
        static void Main(string[] args)
            // Mesmo sendo struct preciso inicializar ou colocando valores ou colocando new //
        {
            point p;
            p = new point();
            p.x = 10;
            p.y = 20;
            Console.WriteLine("Coordenadas de P " + p.ToString());
           
            Console.WriteLine(p);
        }
    }
}