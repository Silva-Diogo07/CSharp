using System;

public class Person
{
    public string Nome { get; set; }
    public int Numero { get; set; }

    public Person(string nome, int numero)
    {
        Nome = nome;
        Numero = numero;
    }
}