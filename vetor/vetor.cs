using System;

class Program
{
    static void Main(string[] args)
    {
        int n1, contador;
        int[] vetor = new int[5];
        Console.Write("Quantos números você deseja digitar (máximo 5): ");
        n1 = Convert.ToInt32(Console.ReadLine());

        for (contador = 0; contador < n1; contador++)
        {
            Console.Write("Digite um número: ");
            vetor[contador] = Convert.ToInt32(Console.ReadLine());
        }

        for (contador = 0; contador < n1; contador++)
        {
            Console.WriteLine("A posição " + contador + " é: " + vetor[contador]);
        }
    }
}

