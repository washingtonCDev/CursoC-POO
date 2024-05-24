using System;
using System.Globalization;

namespace Entradadedados2{ 
    internal class Program{  
       static void Main(string[] args){

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           // primeira forma //
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            string p4 = vet[3];

            Console.WriteLine("Você Digitou:"); 
            Console.WriteLine(n1); 
            Console.WriteLine(ch);       
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Vetor");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine($"{p1} Do Gênero {p2} Tem {p3} Anos e Mede {p4} De Alutra");
            // Segunda Forma //

            Console.WriteLine("/////");
            string[] veto = Console.ReadLine().Split(' ');
            string nome = veto[0];
            char sexo = char.Parse(veto[1]);
            int idade = int.Parse(veto[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Foi Digitado");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
       }  
    }  
} 