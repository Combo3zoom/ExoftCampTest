using WarriorLibrary;

Warrior CreateWarrior()
{
    Warrior? warrior = null;
    uint countPower = 0;
    while (true)
    {
        Console.WriteLine("Choose next options\n" +
                          "1 - generate super power\n" +
                          "2 - choose warrior\n" +
                          "3 - choose type super power\n" +
                          "0 - exit");
        var userChoose = uint.Parse(Console.ReadLine()!);
        switch (userChoose)
        {
            case 1:
                countPower = SuperPowerGenerator.CapacitySuperPower();
                Console.WriteLine($"super power: {countPower}");
                continue;
            case 2:
                Console.WriteLine("Enter type warrior:\n 1-swordmen,\n 2-spearmen,\n 3-bowmen,\n 4-crossbowmen\n");
                var userChooseTypeWarrior = uint.Parse(Console.ReadLine()!);
                warrior = userChooseTypeWarrior switch
                {
                    1 => new Swordmen(),
                    2 => new Spearman(),
                    3 => new Bowman(),
                    4 => new Crossbowman(),
                    _ => null
                };
                continue;
            case 3:
                Console.WriteLine("Enter type super power:\n 1-health,\n 2-armor,\n 3-damage\n");
                var userChooseTypeSuperPower = uint.Parse(Console.ReadLine()!);
                switch (userChooseTypeSuperPower)
                {
                    case 1:
                        warrior!.AddSuperPower(new HealthSuperPower(), countPower);
                        break;
                    case 2:
                        warrior!.AddSuperPower(new ArmorSuperPower(), countPower);
                        break;
                    case 3:
                        warrior!.AddSuperPower(new DamageSuperPower(), countPower);
                        break;
                }
                continue;
            case 0:
                break;
            default:
                continue;
        }
        break;
    }
    Console.WriteLine("===============================");
    return warrior!;
}

Warrior firstWarrior = CreateWarrior();
Warrior secondWarrior = CreateWarrior();
var lastTwoWarriors = BattleArena.Duel(firstWarrior, secondWarrior);
Console.WriteLine($"Winner {lastTwoWarriors[0].GetType()}: {lastTwoWarriors[0].ToString()} " +
                  $"- Defeater {lastTwoWarriors[1].GetType()}: {lastTwoWarriors[1].ToString()}\n" +
                  $"Number od duels {lastTwoWarriors[0].StrikeCounter}");

