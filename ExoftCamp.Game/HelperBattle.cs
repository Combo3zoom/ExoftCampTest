using WarriorLibrary;

public static class HelperBattle
{
    public static BaseWarrior CreateWarrior(string message)
        {
            BaseWarrior? warrior = null;
            Console.WriteLine(message);
            while (true)
            {
                Console.WriteLine("<------------------------------------>");
                Console.WriteLine("Choose next options\n" +
                                  " 1 - current status warrior\n" +
                                  " 2 - choose warrior\n" +
                                  " 3 - choose type super power\n" +
                                  " 0 - exit");
                var userChoose = uint.Parse(Console.ReadLine()!);
                switch (userChoose)
                {
                    case 1:
                        Console.WriteLine(warrior!.ToString());
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
                        Console.WriteLine("<------------------------------------>");
                        Console.WriteLine("Enter type super power:\n 1-health,\n 2-armor,\n 3-damage");
                        var userChooseTypeSuperPower = uint.Parse(Console.ReadLine()!);
                        var countPower = SuperPowerGenerator.CapacitySuperPower();
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
                        Console.WriteLine("Try again\n");
                        continue;
                    
                }
                Console.WriteLine("===============================");
                break;
            }
            return warrior;
        }
}