class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n-----Calculator-----\n");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");

            int option;

            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Opção inválida.");
                Console.Write("Opção: ");
            }

            switch (option)
            {
                case 1:
                    Operations.Somar();
                    break;
                case 2:
                    Operations.Subtrair();
                    break;
                case 3:
                    Operations.Dividir();
                    break;
                case 4:
                    Operations.Multiplicar();
                    break;
                case 5:
                    running = false;
                    Console.WriteLine("Programa terminado!");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
