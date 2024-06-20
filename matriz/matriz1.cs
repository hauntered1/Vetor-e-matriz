using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Digite o número de linhas (M): ");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas (N): ");
        int N = int.Parse(Console.ReadLine());

       
        if (M > 10 || N > 10)
        {
            Console.WriteLine("Máximo de linhas e colunas é 10. Reinicie o programa com valores válidos.");
            return;
        }

        
        double[,] matriz = new double[M, N];
        double[] vetorSomas = new double[M];

        // Leitura da matriz
        Console.WriteLine($"Digite os elementos da matriz {M}x{N}:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        
        for (int i = 0; i < M; i++)
        {
            double somaLinha = 0;
            for (int j = 0; j < N; j++)
            {
                somaLinha += matriz[i, j];
            }
            vetorSomas[i] = somaLinha;
        }

        
        Console.WriteLine("\nVetor de somas das linhas da matriz:");
        for (int i = 0; i < M; i++)
        {
            Console.WriteLine($"Soma da linha {i}: {vetorSomas[i]}");
        }
    }
}
