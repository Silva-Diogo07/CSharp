using System;

public class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Atk { get; set; }
    public bool isDefending {get; set; } 

    public bool Alive => HP > 0;

    public Character(string name, int hp, int atk)
    {
        Name = name;
        HP = hp;
        Atk = atk;
    }

    public void TakeDamage(int damage)
    {
        // Se já estiver morto, não faz nada
        if (!Alive)
            return;
        
        if (isDefending)
        {
            damage /= 2;
            Console.WriteLine($"{Name} defendeu! Dano reduzido para {damage}");
            isDefending = false;
        }

        // Tira dano
        HP -= damage;

        // Garante que HP nunca fica negativo
        if (HP < 0)
            HP = 0;

        // Mostra dano recebido
        Console.WriteLine($"{Name} recebeu {damage} de dano!");

        // Se morreu agora, mostra mensagem
        if (!Alive)
        {
            Console.WriteLine($"{Name} morreu!");
        }
    }

    public void AttackTarget(Character target)
    {
        if (!Alive)
        {
            Console.WriteLine($"{Name} está morto e não pode atacar!");
            return;
        }

        if (!target.Alive)
        {
            Console.WriteLine($"{target.Name} já está morto!");
            return;
        }

        Console.WriteLine($"{Name} atacou {target.Name}!");
        target.TakeDamage(Atk); // TakeDamage vai reduzir se target estiver defendendo
    }

    public void Defend()
    {
        if (!Alive)
            return;
        
        isDefending = true;
        Console.WriteLine($"{Name} defendeu o ataque!");
    }
}