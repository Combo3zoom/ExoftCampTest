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
            var userChoose = Console.ReadLine();
            Console.WriteLine("<------------------------------------>");
            switch (userChoose)
            {
                case "1":
                    if (warrior! == null!)
                    {
                        Console.WriteLine("You need to select warrior!");
                        continue;
                    }
                    Console.WriteLine(warrior!.ToString());
                    continue;
                case "2":
                    Console.WriteLine("Enter type warrior:\n 1 - swordmen,\n 2 - spearmen,\n 3 - bowmen,\n 4 - crossbowmen");
                    var userChooseTypeWarrior = Console.ReadLine()!;
                    warrior = userChooseTypeWarrior switch
                    {
                        "1" => new Swordmen(),
                        "2" => new Spearman(),
                        "3" => new Bowman(),
                        "4" => new Crossbowman(),
                        _ => null
                    };
                    Console.WriteLine($"You chose {warrior!}");
                    continue;
                case "3":
                    if (warrior! == null!)
                    {
                        Console.WriteLine("You need to select warrior!");
                        continue;
                    }
                    Console.WriteLine("Select the type you want to improve super power:\n 1-health,\n 2-armor,\n 3-damage");
                    var userChooseTypeSuperPower = Console.ReadLine()!;
                    switch (userChooseTypeSuperPower)
                    { 
                        case "1":
                            warrior!.AddSuperPower(new HealthSuperPower(),
                                SuperPowerGenerator.CapacitySuperPower());
                            break;
                        case "2":
                            warrior!.AddSuperPower(new ArmorSuperPower(),
                                SuperPowerGenerator.CapacitySuperPower());
                            break;
                        case "3":
                            warrior!.AddSuperPower(new DamageSuperPower(),
                                SuperPowerGenerator.CapacitySuperPower());
                            break;
                    }
                    continue;
                case "0":
                    break;
                default:
                    Console.WriteLine("Try again\n");
                    continue;
                
            }
            Console.WriteLine("The warrior selection was complete");
            Console.WriteLine("===============================");
            break;
        }
        return warrior!;
    }
    
}