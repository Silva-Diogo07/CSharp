using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome de usuário: ");
        string nome_usuario = Console.ReadLine();

        Player player = new Player(nome_usuario, 100, 20);
        Enemy enemy = new Enemy("Goblin", 50, 10);

        Random random = new Random();
        int turno = 1;

        while (player.Alive && enemy.Alive)
        {
            Console.WriteLine($"\n===== Turno {turno} =====");

            // ESCOLHA DO PLAYER
            Console.WriteLine("Escolha sua ação:");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Defender");

            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || (escolha != 1 && escolha != 2))
            {
                Console.Write("Escolha inválida. Digite 1 ou 2: ");
            }

            // DECIDIR ALEATORIAMENTE QUEM ATACA PRIMEIRO
            bool playerFirst = random.Next(2) == 0; // true = player primeiro

            if (playerFirst)
            {
                // Turno do player
                if (escolha == 1)
                    player.AttackTarget(enemy);
                else
                    player.Defend();

                // Turno do bot
                if (enemy.Alive)
                {
                    int bot_action = random.Next(2);
                    if (bot_action == 0)
                    {
                        Console.WriteLine("Goblin escolheu ATACAR!");
                        enemy.AttackTarget(player);
                    }
                    else
                    {
                        Console.WriteLine("Goblin escolheu DEFENDER!");
                        enemy.Defend();
                    }
                }
            }
            else
            {
                // Turno do bot
                if (enemy.Alive)
                {
                    int bot_action = random.Next(2);
                    if (bot_action == 0)
                    {
                        Console.WriteLine("Goblin escolheu ATACAR!");
                        enemy.AttackTarget(player);
                    }
                    else
                    {
                        Console.WriteLine("Goblin escolheu DEFENDER!");
                        enemy.Defend();
                    }
                }

                // Turno do player
                if (player.Alive)
                {
                    if (escolha == 1)
                        player.AttackTarget(enemy);
                    else
                        player.Defend();
                }
            }

            // Mostrar HP de ambos
            Console.WriteLine($"\nHP {player.Name}: {player.HP}");
            Console.WriteLine($"HP {enemy.Name}: {enemy.HP}");

            turno++;
        }

        // Mensagem final
        Console.WriteLine("\n===== FIM DO COMBATE =====");
        if (player.Alive)
            Console.WriteLine($"O vencedor foi {player.Name}!");
        else
            Console.WriteLine($"O vencedor foi {enemy.Name}!");
    }
}
