using WarriorLibrary;

namespace ExoftCamp.Game
{
    static class MainClass
    {
        public static void Main(string[] args)
        {

            var warriors = new List<BaseWarrior>();
            var index = 0;
            while (true)
            {
                Console.WriteLine("===============================");
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
                        // var battleThread1 = new Thread(() => BattleArena.Duel(warriors[0], warriors[1]));
                        // var battleThread2 = new Thread(() => BattleArena.Duel(warriors[2], warriors[3]));
                        // battleThread1.Start();
                        // battleThread2.Start();
                        warriors.Add(new Swordmen());
                        warriors.Add(new Spearman());
                        warriors.Add(new Crossbowman());
                        for (var i = 0; i < warriors.Count; i +=1)
                        {
                            try
                            {
                                var lastTwoWarriors = 
                                    BattleArena.Duel(warriors[i], warriors[++i]);
                                Console.WriteLine($"Winner {lastTwoWarriors[0]}" +
                                                  $"\t- Defeater {lastTwoWarriors[1]}\n" +
                                                  $"Number od duels {BattleArena.roundCounter}\n");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine($"{warriors[warriors.Count-1]}\t didn't fight anyone" );
                            }
                        }
                        Console.WriteLine($"<------The end----->");
                        continue;
                    case "3":
                        warriors.Clear();
                        index = 0;
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

// public static class Ext
// {
//     public static string Ser(this BaseWarrior warrior)//extensional викр для розширення методів
//                                                       //без прямого втручання
//     {
//         var json = SuperPowerGenerator.CapacitySuperPower().ToString();
//         return json;
//     }
// }