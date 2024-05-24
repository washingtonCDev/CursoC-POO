using System;

namespace ExercicioMatriz
{
    /*Fazer um programa para ler dois números inteiros M e N, e depois ler
    uma matriz de M linhas por N colunas contendo números inteiros,
    podendo haver repetições.Em seguida, ler um número inteiro X que
    pertence à matriz.Para cada ocorrência de X, mostrar os valores à
    esquerda, acima, à direita e abaixo de X, quando houver, conforme
    exemplo.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas (M) e colunas (N) da matriz:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            Console.WriteLine("Digite os elementos da matriz:");

            // Preenchendo a matriz
            for (int i = 0; i < m; i++)
            {
                string[] elementos = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(elementos[j]);
                }
            }

            Console.WriteLine("Digite o número que deseja encontrar na matriz:");
            int x = int.Parse(Console.ReadLine());

            // Procurando e exibindo as ocorrências do número na matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine($"Elemento encontrado na posição ({i},{j}):");
                        if (j > 0)
                            Console.WriteLine("Valor à esquerda: " + matriz[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Valor acima: " + matriz[i - 1, j]);
                        if (j < n - 1)
                            Console.WriteLine("Valor à direita: " + matriz[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Valor abaixo: " + matriz[i + 1, j]);
                    }
                }
            }
        }
    }

}