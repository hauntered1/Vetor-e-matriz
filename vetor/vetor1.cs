using System;

class Program
{
    static void Main(string[] args)
    {
        int n1, contador;
        int[] vetor = new int[5];
        int[] negativos = new int[5];
        int[] positivos_ou_zero = new int[5];
        int contador_negativos = 0;
        int contador_positivos_ou_zero = 0;
        int soma_negativos = 0;
        int soma_positivos_ou_zero = 0;

        Console.Write("Quantos números você deseja digitar (máximo 5): ");
        n1 = Convert.ToInt32(Console.ReadLine());

        for (contador = 0; contador < n1; contador++)
        {
            int numero;
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                negativos[contador_negativos] = numero;
                soma_negativos = soma_negativos + numero;
                contador_negativos = contador_negativos + 1;
            }
            else
            {
                positivos_ou_zero[contador_positivos_ou_zero] = numero;
                soma_positivos_ou_zero = soma_positivos_ou_zero + numero;
                contador_positivos_ou_zero = contador_positivos_ou_zero + 1;
            }
        }

        Console.Write("Números negativos: ");
        for (contador = 0; contador < contador_negativos; contador++)
        {
            Console.Write(negativos[contador] + " ");
        }
        Console.Write("\nSoma dos números negativos: " + soma_negativos);

        Console.Write("\nNúmeros positivos ou zero: ");
        for (contador = 0; contador < contador_positivos_ou_zero; contador++)
        {
            Console.Write(positivos_ou_zero[contador] + " ");
        }
        Console.Write("\nSoma dos números positivos ou zero: " + soma_positivos_ou_zero);
    }
}
