public class Enemy : Character
{
    public Enemy(string name, int hp, int atk)
        : base(name, hp, atk)
    {
    }
}

/*
Resumo do Enemy.cs:

- Classe Enemy: herda da classe Character.
- Construtor Enemy(string name, int hp, int atk):
    Cria um Enemy com nome, HP e ataque, usando o construtor da classe base Character.

- Uso:
    O Enemy herda todos os métodos de Character (AttackTarget, TakeDamage, Defend, etc.).
    Futuras lógicas ou ataques especiais do inimigo podem ser adicionadas nesta classe.
*/