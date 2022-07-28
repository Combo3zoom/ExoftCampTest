using WarriorLibrary;

namespace ExoftCamp.Game
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            var firstBaseWarrior = HelperBattle.CreateWarrior("<-----Choose first warrior----->");
            var secondBaseWarrior = HelperBattle.CreateWarrior("<-----Choose second warrior----->");
            var lastTwoWarriors = BattleArena.Duel(firstBaseWarrior, secondBaseWarrior);
            Console.WriteLine($"Winner {lastTwoWarriors[0].ToString()}" +
                              $"\t- Defeater {lastTwoWarriors[1].ToString()}\n" +
                              $"Number od duels {BattleArena.roundCounter}");
        }
    }
}

