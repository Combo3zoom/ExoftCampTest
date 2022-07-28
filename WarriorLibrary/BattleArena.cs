namespace WarriorLibrary;

public static class BattleArena
{
    public static int roundCounter { get; set; }
    public static List<BaseWarrior> Duel(BaseWarrior firstBaseWarrior, BaseWarrior secondBaseWarrior)
    {
        roundCounter = 0;
        for (int i = 0; firstBaseWarrior.HasAlive && secondBaseWarrior.HasAlive; i++)
        {
            ++roundCounter;
            //Console.WriteLine($"\tRound {++roundCounter}\n{firstBaseWarrior.ToString()}\n{secondBaseWarrior.ToString()}");
            if (i % 2 == 0)
                secondBaseWarrior.Defence(firstBaseWarrior.AttackPower());
            else
                firstBaseWarrior.Defence(secondBaseWarrior.AttackPower());
        }

        var winner = firstBaseWarrior.HasAlive
            ? firstBaseWarrior
            : secondBaseWarrior.HasAlive
                ? secondBaseWarrior
                : null;
        var looser = winner != firstBaseWarrior
            ? firstBaseWarrior
            : winner == secondBaseWarrior
                ? secondBaseWarrior
                : null;
        return new List<BaseWarrior>{winner!, looser!};
    }
}