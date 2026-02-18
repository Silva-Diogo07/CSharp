using System;

class Program
{
    static void Main()
    {
        LerEscolha();
    }

    static int LerEscolha()
    {
        void mostrarMenu()
        {
            Console.WriteLine("1 - Adicionar contacto");
            Console.WriteLine("2 - Procurar contacto");
            Console.WriteLine("3 - Apagar Contacto");
        };

        mostrarMenu();

        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha != 1 && escolha != 2 && escolha != 3))
        {
            Console.WriteLine("Escolha inválida. Digite uma das opções válidas: ");
            Console.Clear();
            mostrarMenu();
        }

        Console.WriteLine($"Opção {escolha} foi escolhida.");
        return escolha;
    }
}