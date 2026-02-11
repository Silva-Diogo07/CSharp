    using System;

    public static class Operations
    {
        public static void somar()
        {
            double r_soma = 0.0;
            double numero;

            Console.WriteLine("Digita 00 para terminar.");

            while (true)
            {
                Console.Write("Número: ");
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Input inválido.\nInsere um número: ");

                }

                if (numero == 0)
                {
                    break;
                }
                r_soma += numero;
            }

            Console.WriteLine($"O resultado da soma é: {r_soma:F2}");
        }

        public static void subtrair()
        {
            float r_sub = 0.0f;
            float numero;
            bool primeiro_numero = true;

            Console.WriteLine("Digita '00' para terminar");

            while (true)
            {
                Console.Write("Número: ");
                while (!float.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Input inválido.\nInsere um número: ");
                }

                if (numero == 00)
                {
                    break;
                }

                if (primeiro_numero)
                {
                    r_sub = numero;
                    primeiro_numero = false;
                }
                else
                {
                    r_sub -= numero;
                }
            }

            Console.WriteLine($"O resultado da subtração é: {r_sub:F2}");
        }

        public static void dividir()
        {
            float r_div = 0.0f;
            bool primeiro_numero = true;
            float numero;

            Console.WriteLine("Digita '00' para terminar");

            while (true)
            {
                Console.Write("Número: ");
                while (!float.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Input inválido.\nInsere um número: ");
                }

                if (numero == 00)
                {
                    break;
                }

                if (primeiro_numero)
                {
                    r_div = numero;
                    primeiro_numero = false;
                }
                else
                {
                    r_div /= numero;
                }
            }

            Console.WriteLine($"O resultado da divisão é: {r_div:f3}");
        }
}
