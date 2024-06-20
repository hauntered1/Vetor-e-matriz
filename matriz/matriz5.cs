using System;

class SomaMatrizes
{
    static int[,] LerMatriz(int m, int n, string nome)
    {
        int[,] matriz = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Digite os elementos da linha {i + 1} da matriz {nome}, separados por espaço:");
            string[] elementos = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(elementos[j]);
            }
        }
        return matriz;
    }

    static int[,] SomarMatrizes(int[,] a, int[,] b, int m, int n)
    {
        int[,] c = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }
        return c;
    }

    static void ImprimirMatriz(int[,] matriz, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas (M) da matriz (máximo = 10): ");
        int m = int.Parse(Console.ReadLine());
        while (m > 10)
        {
            Console.Write("Valor inválido! Digite o número de linhas (M) da matriz (máximo = 10): ");
            m = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o número de colunas (N) da matriz (máximo = 10): ");
        int n = int.Parse(Console.ReadLine());
        while (n > 10)
        {
            Console.Write("Valor inválido! Digite o número de colunas (N) da matriz (máximo = 10): ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos da matriz A:");
        int[,] matrizA = LerMatriz(m, n, "A");

        Console.WriteLine("Digite os elementos da matriz B:");
        int[,] matrizB = LerMatriz(m, n, "B");

        int[,] matrizC = SomarMatrizes(matrizA, matrizB, m, n);

        Console.WriteLine("\nMatriz C (soma das matrizes A e B):");
        ImprimirMatriz(matrizC, m, n);
    }
}
