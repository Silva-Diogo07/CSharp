using System;
using System.Collections.Generic;

public class Biblioteca
{
    private List<Livro> livros; // Lista que guarda todos os livros

    // Construtor: inicializa a lista de livros vazia
    public Biblioteca()
    {
        livros = new List<Livro>(); // Começa sem livros
    }

    // Adiciona um livro à biblioteca
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro); // Coloca o livro dentro da lista
        Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca!"); // Mensagem de confirmação
    }

    // Mostra todos os livros que estão na biblioteca
    public void ListarLivros()
    {
        Console.WriteLine("\nLivros na Biblioteca:");
        foreach (var livro in livros) // Para cada livro dentro da lista
        {
            // Mostra título, ano, autor e se está disponível
            Console.WriteLine($"- {livro.Titulo} ({livro.Ano}) de {livro.Autor} - Disponível: {livro.Disponivel}");
        }
    }

    // Procura um livro pelo título
    public Livro? ProcurarLivro(string titulo)
    {
        foreach (var livro in livros) // Olha cada livro na lista
        {
            // Compara o título digitado com o título do livro
            if (livro.Titulo.ToLower() == titulo.ToLower())
                return livro; // Se achar, retorna o livro
        }
        return null; // Se não achar, retorna nada (null)
    }
}
