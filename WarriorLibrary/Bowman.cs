namespace WarriorLibrary;

public class Bowman: Warrior
{
    public Bowman() : base()
    {
        Armor = 2;
    }

    public override void AddSuperPower(IWarriorSuperPower warriorSuperPower, uint countPower)
    {
        base.AddSuperPower(warriorSuperPower, countPower);
    }
}