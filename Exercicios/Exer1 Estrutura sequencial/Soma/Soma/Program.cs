using System;

//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa.

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Um Número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Outro Número:");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"Soma = {soma}");
        }
    }
}