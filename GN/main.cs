using System;

class Program
{
    static void Main()
    {
        int numero = GerarNumero();
        
        Console.WriteLine(numero); // Debug
        Console.WriteLine("Adivinha o número de 1-50: ");

        string input = Console.ReadLine();
        int guess = int.Parse(input);

        int tentativas = 3;

        while (guess != numero && tentativas > 1)
        {
            tentativas --;
            Console.WriteLine($"Tentativas restantes: {tentativas}");
            guess = pedir_palpite();
        }

        if (guess == numero)
        {
            Console.WriteLine("Parabéns! Adivinhaste o número");
        }
        else
        {
            Console.WriteLine($"Acabaram as tentativas o número era {numero}");
        }

    }

    static int pedir_palpite()
    {
        Console.WriteLine("Tenta outra vez: ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);
        return guess;
    }

    static int GerarNumero()
    {
        Random rnd = new Random();
        return rnd.Next(1, 51);
    }
}
