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
        string nome = Console.ReadLine() ?? ""; // aceita qualquer coisa

        int numero;
        Console.Write("Número telefónico do contacto: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Digite um número válido:");
        }

        contactos.Add(new Person(nome, numero));
        Console.WriteLine($"Contacto {nome} adicionado com sucesso!\n");
        Console.Clear();
    }

    public void ProcurarContacto()
    {
        Console.Clear();

        Console.Write("Nome: ");
        string nomeProcurado = Console.ReadLine() ?? "";

        foreach (Person contacto in contactos)
        {
            if (contacto.Nome.Equals(nomeProcurado, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nome: {contacto.Nome} | número de telefone: {contacto.Numero}");
                break;
            }
        }
    }

    public void ListarContactos()
    {
        Console.Clear();

        if (contactos.Count == 0)
        {
            Console.WriteLine("Não existem contactos guardados.\n");
            return;
        }

        int i = 1;

        foreach (Person contacto in contactos)
        {
            Console.WriteLine($"{i}. Nome: {contacto.Nome} | número de telefone: {contacto.Numero}\n");
            i++;
        }
    }

    public void RemoverContacto()
    {
        Console.Clear();

        Console.Write("Digita o nome do contacto que desejas apagar: ");
        string nome_apagar = Console.ReadLine() ?? "";

        var contacto = contactos.RemoveAll(c => c.Nome.Equals(nome_apagar, StringComparison.OrdinalIgnoreCase));
        if (contacto != null)
        {
            contactos.Remove(contacto);
            Console.WriteLine("Contacto apagado com sucesso");
        }
        else
            Console.WriteLine("Contacto não encontrado");

    }
}