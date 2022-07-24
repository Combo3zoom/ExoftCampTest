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

    public float Health { get; set; }
    public float Armor { get; set; }
    public float Damage { get; set; }
    public const uint SumArmorAndDamage = 20;
    public virtual void AddSuperPower(IWarriorSuperPower warriorSuperPower, uint countPower)
    {
        warriorSuperPower.AddSuperPower(this,countPower);
    }
}