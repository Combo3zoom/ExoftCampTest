using WarriorLibrary;

namespace ExoftCamp.Game
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            var warriors = new List<BaseWarrior>();
            var index = 0;
            var indexBattle = 0;
            while (true)
            {
                Console.WriteLine($"Select:\n" +
                                  $"1 - add warrior\n" +
                                  $"2 - begin fight\n" +
                                  $"3 - clear list\n" +
                                  $"0 - exit");
                var userChoose = Console.ReadLine();
                switch (userChoose)
                {
                    case "1":
                        var firstWarrior = HelperBattle.CreateWarrior($"<-----Choose {++index}-st warrior----->");
                        warriors.Add(firstWarrior);
                        continue;
                    case "2":
                        while (warriors.Count != indexBattle)
                        {
                            var lastTwoWarriors = 
                                BattleArena.Duel(warriors[indexBattle++], warriors[indexBattle++]);
                            Console.WriteLine($"Winner {lastTwoWarriors[0]}" +
                                              $"\t- Defeater {lastTwoWarriors[1]}\n" +
                                              $"Number od duels {BattleArena.roundCounter}\n");
                        }
                        Console.WriteLine($"<------The end----->");
                        continue;
                    case "3":
                        warriors.Clear();
                        continue;
                    case "0":
                        break;
                    default:
                        continue;
                }

                break;
            }
        }
    }
}

