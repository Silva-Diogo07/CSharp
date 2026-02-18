class Program
{
    static void Main()
    {
        Gerir gerir = new Gerir();

        while (true)
        {
            Console.WriteLine("1 - Adicionar contacto");
            Console.WriteLine("2 - Procurar contacto");
            Console.WriteLine("3 - Listar contactos");
            Console.WriteLine("4 - Remover contacto");
            Console.WriteLine("0 - Sair");

            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha > 4)
            {
                Console.WriteLine("Escolha inválida.");
            }

            if (escolha == 0)
                break;

            switch (escolha)
            {
                case 1:
                    gerir.AdicionarContacto();
                    break;
                case 2:
                    gerir.ProcurarContacto();
                    break;
                case 3:
                    gerir.ListarContactos();
                    break;
                case 4:
                    gerir.RemoverContacto();
                    break;
            }
        }
    }
}
