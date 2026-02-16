using System;

class Program
{
    static void Main()
    {
        // Cria uma nova biblioteca vazia
        Biblioteca minhaBiblioteca = new Biblioteca(); 

        // Variável para controlar se o menu deve continuar aberto
        bool running = true; 

        // Loop do menu: continua até o usuário escolher sair
        while (running)
        {
            Console.WriteLine("\n----- Biblioteca -----\n");
            Console.WriteLine("1. Listar livros");
            Console.WriteLine("2. Adicionar livro");
            Console.WriteLine("3. Procurar livro");
            Console.WriteLine("4. Sair");
            Console.Write("Opção: ");

            // Lê a opção do usuário e garante que é um número
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Opção inválida. Digite um número!");
                Console.Write("Opção: ");
            }

            // Verifica a opção escolhida e chama a função correspondente
            switch (option)
            {
                case 1:
                    minhaBiblioteca.ListarLivros(); // Lista todos os livros
                    break;
                case 2:
                    AdicionarLivroMenu(minhaBiblioteca); // Pede dados e adiciona livro
                    break;
                case 3:
                    ProcurarLivroMenu(minhaBiblioteca); // Pede título e procura livro
                    break;
                case 4:
                    running = false; // Sai do programa
                    Console.WriteLine("Programa terminado!");
                    break;
                default:
                    Console.WriteLine("Opção inválida."); // Qualquer outro número
                    break;
            }
        }
    }

    // Método que lê dados do usuário para criar um livro e adicionar à biblioteca
    static void AdicionarLivroMenu(Biblioteca biblioteca)
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine() ?? ""; // Lê o título

        Console.Write("Autor: ");
        string autor = Console.ReadLine() ?? "";   // Lê o autor

        Console.Write("Ano: ");
        int ano;
        while (!int.TryParse(Console.ReadLine(), out ano)) // Lê o ano e garante que é número
        {
            Console.WriteLine("Ano inválido! Digite apenas números.");
            Console.Write("Ano: ");
        }

        // Cria um livro com os dados fornecidos
        Livro livro = new Livro(titulo, autor, ano);

        // Adiciona o livro à biblioteca
        biblioteca.AdicionarLivro(livro); 
    }

    // Método que lê título do usuário e procura livro na biblioteca
    static void ProcurarLivroMenu(Biblioteca biblioteca)
    {
        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine() ?? ""; // Lê título

        // Procura o livro pelo título
        Livro? encontrado = biblioteca.ProcurarLivro(titulo);

        // Mostra resultado
        if (encontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {encontrado.Titulo} de {encontrado.Autor}, Ano: {encontrado.Ano}, Disponível: {encontrado.Disponivel}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado!");
        }
    }
}
