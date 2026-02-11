using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Calculator-----\n");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Opção: ");

        int option;

        while (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Opção inválida.");
            Console.WriteLine("Opção: ");
        }

        switch (option)
        {
            case 1: 
                Operations.somar();
                break;
            case 2:
                //subtrair();
                break;
            case 3:
                //multiplicar();
                break;
            case 4:
                //dividir();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}