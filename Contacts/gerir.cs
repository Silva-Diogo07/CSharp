using System;
using System.Collections.Generic;
using System.Linq;

public class Gerir
{
    private List<Person> contactos = new List<Person>();

    public void AdicionarContacto()
    {
        Console.Clear();
        Console.Write("Nome do contacto: ");
        string nome = Console.ReadLine() ?? "";

        int numero;
        Console.Write("Número telefónico do contacto: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Digite um número válido:");
        }

        contactos.Add(new Person(nome, numero));
        Console.WriteLine($"Contacto {nome} adicionado com sucesso!\n");
    }

    public void ProcurarContacto()
    {
        Console.Clear();
        Console.Write("Nome: ");
        string nomeProcurado = Console.ReadLine() ?? "";

        var contacto = contactos.FirstOrDefault(c => 
            c.Nome.Equals(nomeProcurado, StringComparison.OrdinalIgnoreCase));

        if (contacto != null)
            Console.WriteLine($"Nome: {contacto.Nome} | Número: {contacto.Numero}\n");
        else
            Console.WriteLine("Contacto não encontrado.\n");
    }

    public void ListarContactos()
    {
        Console.Clear();

        if (contactos.Count == 0)
        {
            Console.WriteLine("Não existem contactos guardados.\n");
            return;
        }

        // Ordenar nome por ordem ascendente
        var contactosOrdenados = contactos.OrderBy(c => c.Nome);
        
        int i = 1;

        foreach (Person contacto in contactosOrdenados)
        {
            Console.WriteLine($"{i} Nome: {contacto.Nome} | Número: {contacto.Numero} ");
            i++;
        }
        
        Console.WriteLine();
    }

    public void RemoverContacto()
    {
        Console.Clear();
        Console.Write("Digite o nome do contacto que deseja apagar: ");
        string nome_apagar = Console.ReadLine() ?? "";

        int removidos = contactos.RemoveAll(c =>
            c.Nome.Equals(nome_apagar, StringComparison.OrdinalIgnoreCase));

        if (removidos > 0)
            Console.WriteLine("Contacto(s) apagado(s) com sucesso!\n");
        else
            Console.WriteLine("Contacto não encontrado.\n");
    }

    public void EditarContacto()
    {
        Console.Clear();
        Console.Write("Digite o nome do contacto que deseja editar: ");
        string nomeEditar = Console.ReadLine() ?? "";

        var contacto = contactos.FirstOrDefault(c =>
            c.Nome.Equals(nomeEditar, StringComparison.OrdinalIgnoreCase));

        if (contacto != null)
        {
            Console.WriteLine($"Nome atual: {contacto.Nome} | Número atual: {contacto.Numero}");

            Console.Write("Novo nome (pressione Enter para manter o atual): ");
            string novoNome = Console.ReadLine() ?? "";

            Console.Write("Novo número (pressione Enter para manter o atual): ");
            string inputNumero = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(novoNome))
                contacto.Nome = novoNome;

            if (int.TryParse(inputNumero, out int novoNumero))
                contacto.Numero = novoNumero;

            Console.WriteLine("Contacto atualizado com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Contacto não encontrado.\n");
        }
    }
}
