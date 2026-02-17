using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Player player = CriarPlayer();
        Enemy enemy = CriarEnemy();

        RodarBatalha(player, enemy);
    }

    static Player CriarPlayer()
    {
        Console.Write("Digite o nome de usuário: ");
        string nome = Console.ReadLine();
        return new Player(nome, 100, 20);
    }

    static Enemy CriarEnemy()
    {
        return new Enemy("Goblin", 50, 10);
    }

    static void RodarBatalha(Player player, Enemy enemy)
    {
        int turno = 1;
        while (player.Alive && enemy.Alive)
        {
            Console.WriteLine($"\n===== Turno {turno} =====");

            int escolha = LerEscolhaPlayer();

            bool playerFirst = random.Next(2) == 0;

            if (playerFirst)
            {
                TurnoPlayer(player, enemy, escolha);
                TurnoEnemy(enemy, player);
            }
            else
            {
                TurnoEnemy(enemy, player);
                TurnoPlayer(player, enemy, escolha);
            }

            MostrarStatus(player, enemy);
            turno++;
        }

        MostrarVencedor(player, enemy);
    }

    static int LerEscolhaPlayer()
    {
        Console.WriteLine("Escolha sua ação:");
        Console.WriteLine("1 - Atacar");
        Console.WriteLine("2 - Defender");

        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha != 1 && escolha != 2))
        {
            Console.Write("Escolha inválida. Digite 1 ou 2: ");
        }

        return escolha;
    }

    static void TurnoPlayer(Player player, Enemy enemy, int escolha)
    {
        if (!player.Alive) return;

        if (escolha == 1)
            player.AttackTarget(enemy);
        else
            player.Defend();
    }

    static void TurnoEnemy(Enemy enemy, Player player)
    {
        if (!enemy.Alive) return;

        int bot_action = random.Next(2);
        if (bot_action == 0)
        {
            Console.WriteLine($"{enemy.Name} escolheu ATACAR!");
            enemy.AttackTarget(player);
        }
        else
        {
            Console.WriteLine($"{enemy.Name} escolheu DEFENDER!");
            enemy.Defend();
        }
    }

    static void MostrarStatus(Player player, Enemy enemy)
    {
        Console.WriteLine($"\nHP {player.Name}: {player.HP}");
        Console.WriteLine($"HP {enemy.Name}: {enemy.HP}");
    }

    static void MostrarVencedor(Player player, Enemy enemy)
    {
        Console.WriteLine("\n===== FIM DO COMBATE =====");
        if (player.Alive)
            Console.WriteLine($"O vencedor foi {player.Name}!");
        else
            Console.WriteLine($"O vencedor foi {enemy.Name}!");
    }
}
