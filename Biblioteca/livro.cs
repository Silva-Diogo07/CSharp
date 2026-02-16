public class Livro
{
    // Título do livro
    public string Titulo { get; set; }

    // Nome do autor
    public string Autor { get; set; }

    // Ano de publicação
    public int Ano { get; set; }

    // Se o livro está disponível ou não
    public bool Disponivel { get; set; }

    // Construtor: cria um novo livro com título, autor e ano
    // Quando um livro é criado , aparece como disponivel
    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;      // Define o título do livro
        Autor = autor;        // Define o autor do livro
        Ano = ano;            // Define o ano de publicação
        Disponivel = true;    // Marca o livro como disponível
    }
}
