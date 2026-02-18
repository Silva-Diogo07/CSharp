public class Player : Character
{
    public Player(string name, int hp, int atk)
        : base(name, hp, atk)
    {
    }
}

/*
Resumo do Player.cs:

- Classe Player: herda da classe Character.
- Construtor Player(string name, int hp, int atk):
    Cria um Player com nome, HP e ataque, usando o construtor da classe base Character.

- Uso:
    O Player herda todos os métodos de Character (AttackTarget, TakeDamage, Defend, etc.).
    Futuras habilidades especiais do jogador podem ser adicionadas nesta classe.
*/