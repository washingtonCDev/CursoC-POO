using System;
// aula 18 - seção 6 - Exercicio Matrizes
/* Fazer um programa para ler um número inteiro N e uma matriz de 
ordem N contendo números inteiros. Em seguida, mostrar a diagonal 
principal e a quantidade de valores negativos da matriz. */
namespace ExercicioMatrizesResolvido
{   // ditamos pra testar 5 -3 10
    // 15 8 2
    // 7 9 -4
    // diagonal principal: 5 8 -4 = i0j0 i1j1 i2j2

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Será o Tamanho da Matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Console.WriteLine($"Matriz de Tamanho {n}x{n}");

            for (int i = 0; i < n; i++) // percorrer as Linhas 
            {
                string[] values = Console.ReadLine().Split(' '); // armazena a linha os valores em string

                for (int j = 0; j < n; j++) // percorrer as Colunas
                {
                mat[i,j] = int.Parse(values[j]); // values na posição j é convertido pra int
                }// mat armazena resultado na linha i coluna j
                Console.WriteLine();
            }
            // values arnazena o dado na linha mas embaixo no for 2 e values le na coluna j
            // assim = i 0 na coluna 0 é 5 então a matriz recebe 5 na liina 0 coluna 0 
            // depois de receber todos os dados das colunas retorna o programa a ler o primeiro FOR
            // para ler a proxima linha

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i<n; i++)
            {
                Console.Write(mat[i,i] +" "); // linha i coluna i pra mostrar os principais
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0;i<n; i++)// matriz pra line e coluna e se mat i e j < 0 count adiciona mais 1
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                      count++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}