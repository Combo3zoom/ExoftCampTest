using WarriorLibrary;

public static class HelperBattle
{
    public static BaseWarrior CreateWarrior(string message)
        {
            BaseWarrior? warrior = null;
            uint countPower = 0;
            Console.WriteLine(message);
            while (true)
            {
                Console.WriteLine("<------------------------------------>");
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
                        Console.WriteLine("<------------------------------------>");
                        Console.WriteLine("Enter type warrior:\n 1 - swordmen,\n 2 - spearmen,\n 3 - bowmen,\n 4 - crossbowmen");
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
                        if (countPower == 0)
                        {
                            Console.WriteLine("You need to generate a number");
                            continue;
                        }
                        Console.WriteLine("<------------------------------------>");
                        Console.WriteLine("Enter type super power:\n 1-health,\n 2-armor,\n 3-damage");
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
                        if(warrior != null)
                            break;
                        Console.WriteLine("Select Warrior");
                        continue;
                    default:
                        Console.WriteLine("Try again\n");
                        continue;
                    
                }
                Console.WriteLine("===============================");
                break;
            }
            return warrior;
        }
}