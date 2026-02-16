using System;

class Program
{
    static void Main()
    {
        Player player = new Player("Jogador", 100, 20);
        Enemy enemy = new Enemy("Goblin", 50, 10);

        Console.WriteLine($"{player.Name} tem {player.Hitpoints} HP e {player.Attack} de ataque");
        Console.WriteLine($"{enemy.Name} tem {enemy.Hitpoints} HP e {enemy.Attack} de ataque");

        player.AttackTarget(enemy);
        enemy.AttackTarget(player);

        Console.WriteLine($"O Jogador agora tem {player.Hitpoints} HP");
        Console.WriteLine($"O Goblin agora tem {enemy.Hitpoints} HP");

        while (player.Alive && enemy.Alive)
        {
            player.AttackTarget(enemy);

            if (enemy.Alive)
            {
                enemy.AttackTarget(player);
            }

        Console.WriteLine($"Jogador: {player.Hitpoints} HP");
        Console.WriteLine($"Goblin: {enemy.Hitpoints} HP");
        }

        Console.WriteLine($"O jogador está vivo: {player.Alive}");
        Console.WriteLine($"O Goblin está vivo: {enemy.Alive}");
    }
}
