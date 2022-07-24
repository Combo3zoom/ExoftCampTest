namespace WarriorLibrary;

public abstract class Warrior
{
    private bool _hasAlive;
    private float _armor;

    protected Warrior(float health, float armor)
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

    public float Armor
    {
        get => _armor;
        set
        {
            if (value < 0)
            {
                _armor = 0;
            }
            else
            {
                _armor = value;
            }

        }
    }

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

    public override string ToString()
    {
        return $"Health: {Health}, Armor: {Armor}, Damage: {Damage}\n";
    }
}