using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantas pessoas serão cadastradas? ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];
        double[] alturas = new double[n];
        int countMenorDe16 = 0;
        double somaAlturas = 0;

        // Entrada de dados
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nDados da pessoa " + (i + 1) + ":");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();
            Console.Write("Idade: ");
            idades[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Altura (em metros): ");
            alturas[i] = Convert.ToDouble(Console.ReadLine());

            somaAlturas += alturas[i];

            if (idades[i] < 16)
            {
                countMenorDe16++;
            }
        }

        
        double alturaMedia = somaAlturas / n;

        // Saída de dados
        Console.WriteLine("\nAltura média das pessoas: " + alturaMedia.ToString("F2") + " metros");

        double porcentagemMenorDe16 = (countMenorDe16 * 100.0) / n;
        Console.WriteLine("Porcentagem de pessoas com menos de 16 anos: " + porcentagemMenorDe16.ToString("F2") + "%");

       
        if (countMenorDe16 > 0)
        {
            Console.WriteLine("Nomes das pessoas com menos de 16 anos:");
            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
