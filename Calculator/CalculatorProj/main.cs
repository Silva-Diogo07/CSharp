using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Calculator-----\n");
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Dividir");
        Console.WriteLine("4. Multiplicar");
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
                Operations.subtrair();
                break;
            case 3:
                Operations.dividir();
                break;
            case 4:
                //multiplicar();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}