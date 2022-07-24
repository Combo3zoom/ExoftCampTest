using WarriorLibrary;

Console.WriteLine("Hello, World!");
var randomValue1 = SuperPowerGenerator.CapacitySuperPower();
var randomValue2 = SuperPowerGenerator.CapacitySuperPower();
var randomValue3 = SuperPowerGenerator.CapacitySuperPower();
Console.WriteLine($"{randomValue1}, {randomValue2}, {randomValue3}");


Swordmen swordmen = new Swordmen();
Console.WriteLine(swordmen.Damage);
{
    swordmen.AddSuperPower(new ArmorSuperPower(), 12);
}
Console.WriteLine(swordmen.Damage);
Bowman bowman = new Bowman();
var a = BattleArena.Duel(swordmen,bowman);

Console.WriteLine($"Winner {a.GetType()}: {a.ToString()}");
