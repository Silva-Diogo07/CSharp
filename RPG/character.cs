using System;

public class Character
{
    public string Name { get; set; }
    public int Hitpoints { get; set; }
    public int Attack { get; set; }

    public bool Alive => Hitpoints > 0;

    public Character(string name, int hitpoints, int attack)
    {
        Name = name;
        Hitpoints = hitpoints;
        Attack = attack;
    }

    public void TakeDamage(int damage)
{
    // Se já estiver morto, não faz nada
    if (!Alive)
        return;

    // Tira dano
    Hitpoints -= damage;

    // Garante que HP nunca fica negativo
    if (Hitpoints < 0)
        Hitpoints = 0;

    // Mostra dano recebido
    Console.WriteLine($"{Name} recebeu {damage} de dano!");

    // Se morreu agora, mostra mensagem
    if (!Alive)
        Console.WriteLine($"{Name} morreu!");
}


    public void AttackTarget(Character target)
    {
        Console.WriteLine($"{Name} atacou {target.Name}!");
        target.TakeDamage(Attack);
    }
}