namespace WarriorLibrary;

public abstract class Warrior
{
    private bool _hasAlive;

    protected Warrior(uint health, uint armor, uint strikeCount)
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

    public bool HasAlive
    {
        get
        {
            if (Health <= 0)
            {
                return false;
            }
            return true;
        }
    }

    public const uint SumArmorAndDamage = 20;
    public uint StrikeCounter { get; set; }
    public virtual void AddSuperPower(IWarriorSuperPower warriorSuperPower, uint countPower)
    {
        warriorSuperPower.AddSuperPower(this,countPower);
    }
}