using WarriorLibrary;


var firstBaseWarrior = HelperBattle.CreateWarrior("<-----Choose first warrior----->");
var secondBaseWarrior = HelperBattle.CreateWarrior("<-----Choose second warrior----->");
var lastTwoWarriors = BattleArena.Duel(firstBaseWarrior, secondBaseWarrior);
Console.WriteLine($"Winner {lastTwoWarriors[0].ToString()} " +
                  $"- Defeater {lastTwoWarriors[1].ToString()}\n" +
                  $"Number od duels {BattleArena.roundCounter}");




