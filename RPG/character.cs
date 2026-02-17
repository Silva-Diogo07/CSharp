using System;

public class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Atk { get; set; }
    public bool isDefending { get; set; }

    public bool Alive => HP > 0;

    public Character(string name, int hp, int atk)
    {
        Name = name;
        HP = hp;
        Atk = atk;
    }

    public int GetDamageAfterDefense(int damage)
    {
        if (isDefending)
        {
            damage /= 2;
            Console.WriteLine($"{Name} defendeu! Dano reduzido para {damage}");
            isDefending = false;
        }
        return damage;
    }

    public void TakeDamage(int damage)
    {
        if (!Alive) return;

        damage = GetDamageAfterDefense(damage);

        HP -= damage;
        if (HP < 0) HP = 0;

        Console.WriteLine($"{Name} recebeu {damage} de dano!");

        if (!Alive)
            Console.WriteLine($"{Name} morreu!");
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
        target.TakeDamage(Atk);
    }

    public void Defend()
    {
        if (!Alive) return;

        isDefending = true;
        Console.WriteLine($"{Name} defendeu o ataque!");
    }
}

