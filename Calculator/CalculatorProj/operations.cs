using System;

public static class Operations
{
    public static void Somar()
    {
        double resultado = 0;
        Console.WriteLine("Digite '00' para calcular.");

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine() ?? "";

            if (input == "00")
                break;

            if (!double.TryParse(input, out double numero))
            {
                Console.WriteLine("Input inválido.");
                continue;
            }

            resultado += numero;
        }

        Console.WriteLine($"Resultado da soma: {resultado:F2}");
    }

    public static void Subtrair()
    {
        double resultado = 0;
        bool primeiro = true;

        Console.WriteLine("Digite '00' para calcular.");

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine() ?? "";

            if (input == "00")
                break;

            if (!double.TryParse(input, out double numero))
            {
                Console.WriteLine("Input inválido.");
                continue;
            }

            if (primeiro)
            {
                resultado = numero;
                primeiro = false;
            }
            else
            {
                resultado -= numero;
            }
        }

        Console.WriteLine($"Resultado da subtração: {resultado:F2}");
    }

    public static void Dividir()
    {
        double resultado = 0;
        bool primeiro = true;

        Console.WriteLine("Digite '00' para calcular.");

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine() ?? "";

            if (input == "00")
                break;

            if (!double.TryParse(input, out double numero))
            {
                Console.WriteLine("Input inválido.");
                continue;
            }

            if (primeiro)
            {
                resultado = numero;
                primeiro = false;
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    continue;
                }

                resultado /= numero;
            }
        }

        Console.WriteLine($"Resultado da divisão: {resultado:F3}");
    }

    public static void Multiplicar()
    {
        double resultado = 0;
        bool primeiro = true;

        Console.WriteLine("Digite '00' para calcular.");

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine() ?? "";

            if (input == "00")
                break;

            if (!double.TryParse(input, out double numero))
            {
                Console.WriteLine("Input inválido.");
                continue;
            }

            if (primeiro)
            {
                resultado = numero;
                primeiro = false;
            }
            else
            {
                resultado *= numero;
            }
        }

        Console.WriteLine($"Resultado da multiplicação: {resultado:F2}");
    }
}
