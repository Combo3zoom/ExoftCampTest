namespace WarriorLibrary;

public abstract class Warrior
{
    protected Warrior(uint health, uint armor)
    {
        Health = health;
        Armor = armor;
        Damage = SumArmorAndDamage - Armor;
    }

    protected Warrior()
    {
        Health = 100;
        Armor = 0;
        Damage = SumArmorAndDamage - Armor;
    }

    public uint Health { get; set; }
    public uint Armor { get; set; }
    public uint Damage { get; }
    public const uint SumArmorAndDamage = 20;
}