using WarriorLibrary;

Console.WriteLine("Hello, World!");
var randomValue1 = SuperPowerGenerator.CapacitySuperPower();
var randomValue2 = SuperPowerGenerator.CapacitySuperPower();
var randomValue3 = SuperPowerGenerator.CapacitySuperPower();
Console.WriteLine($"{randomValue1}, {randomValue2}, {randomValue3}");


Swordmen swordmen = new Swordmen();
Console.WriteLine(swordmen.Damage);
{
    swordmen.AddSuperPower(new DamageSuperPower(), 12);
}
Console.WriteLine(swordmen.Damage);
