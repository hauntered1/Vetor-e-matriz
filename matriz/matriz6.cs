using System;

class CadaLinha
{
    static double[,] LerMatriz(int n)
    {
        double[,] matriz = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite os elementos da linha {i + 1}, separados por espaço:");
            string[] elementos = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = double.Parse(elementos[j]);
            }
        }
        return matriz;
    }

    static double[] MaiorElementoPorLinha(double[,] matriz)
    {
        int n = matriz.GetLength(0);
        double[] maioresElementos = new double[n];

        for (int i = 0; i < n; i++)
        {
            double maior = matriz[i, 0];
            for (int j = 1; j < n; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
            maioresElementos[i] = maior;
        }

        return maioresElementos;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite a ordem da matriz (máximo = 10): ");
        int n = int.Parse(Console.ReadLine());
        while (n > 10)
        {
            Console.Write("Ordem inválida! Digite a ordem da matriz (máximo = 10): ");
            n = int.Parse(Console.ReadLine());
        }

        double[,] matriz = LerMatriz(n);

        double[] maioresElementos = MaiorElementoPorLinha(matriz);

        Console.WriteLine("\nMaior elemento de cada linha:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Linha {i + 1}: {maioresElementos[i]}");
        }
    }
}
