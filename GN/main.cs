using System;

class Program
{
    static Random rnd = new Random();

    static void Main()
    {
        int numero = GerarNumero();
        
        Console.WriteLine("Adivinha o número de 1-50 ");

        int tentativas = 3;
        int guess = pedir_palpite();

        while (guess != numero && tentativas > 1)
        {
            if (guess > numero)
            {
                Console.WriteLine("Mais Baixo!");
            }
            else
            {
                Console.WriteLine("Mais Alto!");
            }

            tentativas--;
            Console.WriteLine($"Tentativas restantes: {tentativas}");

            guess = pedir_palpite();
        }

        if (guess == numero)
        {
            Console.WriteLine("Parabéns, adivinhaste o número!");
        }
        else
        {
            Console.WriteLine($"Acabaram as tentativas, o número era: {numero}");
        }
    }

    static int pedir_palpite()
    {
        while (true)
        {
            Console.Write("Palpite: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int guess) && guess >= 1 && guess <= 50)
            {
                return guess;
            }

            Console.WriteLine("Input inválido! Escreve um número entre 1 e 50.");
        }
    }

    static int GerarNumero()
    {
        return rnd.Next(1, 51);
    }
}
