    using System;

    public static class Operations
    {
        public static void somar()
        {
            double soma = 0.0;
            double numero;

            Console.WriteLine("Escreve 0 para terminar.");

            while (true)
            {
                Console.Write("Número: ");
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Input inválido.\nInsere um número: ");

                }

                if (numero == 0)
                    break;

                soma += numero;
            }

            Console.WriteLine($"A soma total é: {soma:F2}");
        }
    }
