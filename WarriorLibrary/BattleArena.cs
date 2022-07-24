namespace WarriorLibrary;

public static class BattleArena
{
    public static List<Warrior> Duel(Warrior firstWarrior, Warrior secondWarrior)
    {
        for (int i = 0; firstWarrior.HasAlive && secondWarrior.HasAlive; i++)
        {
            if (i % 2 == 0)
            {
                Defence(AttackPower(firstWarrior, secondWarrior), secondWarrior);
            }
            else
            {
                Defence(AttackPower(secondWarrior, firstWarrior), firstWarrior);
            }
        }

        if (firstWarrior.HasAlive)
        {
            return new List<Warrior>{firstWarrior, secondWarrior};
        }
        return new List<Warrior>{secondWarrior, firstWarrior};
    }

    private static void Defence(float doneDamage, Warrior defenceWarrior)
    {
        if (defenceWarrior.Armor <= 0)
        {
            defenceWarrior.Health -= doneDamage;
        }
        else
        {
            defenceWarrior.Armor -= doneDamage / 2;
            defenceWarrior.Health -= doneDamage / 2;
        }
    }

    private static float AttackPower(Warrior attackWarrior, Warrior defenceWarrior)
    {
        attackWarrior.StrikeCounter++;
        if (attackWarrior.Armor <= 0)
        {
            var resultDamage = attackWarrior.Damage - defenceWarrior.StrikeCounter;
            if (resultDamage < 1)
            {
                return 1;
            }
            return resultDamage;
        }
        return attackWarrior.Damage;
    }
}