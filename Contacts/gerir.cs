using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

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

        var resultados = contactos.Where(c =>
            c.Nome.Contains(nomeProcurado, StringComparison.OrdinalIgnoreCase));

        if (resultados.Any())
        {
            foreach (var c in resultados)
            {
                Console.WriteLine($"Nome: {c.Nome} | Número: {c.Numero}");
            }
        }
        else
        {
            Console.WriteLine("Contacto não encontrado.");
        }

        Console.WriteLine();
    }

    public void ListarContactos()
    {
        Console.Clear();

        if (contactos.Count == 0)
        {
            Console.WriteLine("Não existem contactos guardados.\n");
            return;
        }

        var contactosOrdenados = contactos.OrderBy(c => c.Nome);

        int i = 1;

        foreach (var contacto in contactosOrdenados)
        {
            Console.WriteLine($"{i}. Nome: {contacto.Nome} | Número: {contacto.Numero}");
            i++;
        }

        Console.WriteLine();
    }

    public void RemoverContacto()
    {
        Console.Clear();
        Console.Write("Digite o nome do contacto que deseja apagar: ");
        string nomeApagar = Console.ReadLine() ?? "";

        int removidos = contactos.RemoveAll(c =>
            c.Nome.Equals(nomeApagar, StringComparison.OrdinalIgnoreCase));

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

            Console.Write("Novo nome (Enter para manter): ");
            string novoNome = Console.ReadLine() ?? "";

            Console.Write("Novo número (Enter para manter): ");
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

    public void SalvarContactos()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(contactos, options);
        File.WriteAllText("contactos.json", jsonString);
    }

    public void CarregarContactos()
    {
        if (File.Exists("contactos.json"))
        {
            string jsonString = File.ReadAllText("contactos.json");

            if (!string.IsNullOrWhiteSpace(jsonString))
            {
                contactos = JsonSerializer.Deserialize<List<Person>>(jsonString)
                            ?? new List<Person>();
            }
            else
            {
                contactos = new List<Person>();
            }
        }
        else
        {
            contactos = new List<Person>();
        }
    }
}
