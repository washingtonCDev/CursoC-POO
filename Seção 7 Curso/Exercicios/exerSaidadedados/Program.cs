using System;
using System.Globalization;

namespace exerSaidadedados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prod1 = "Computador";
            string prod2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{prod1}, cujo o preço é ${preco1:f2}");
            Console.WriteLine($"{prod2}, cujo o preço é ${preco2:f2}");

            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais: {medida:f8}");
            Console.WriteLine($"Arredondando (Três casas decimais): {medida:f3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("f3",CultureInfo.InvariantCulture));
        }
    }
}
