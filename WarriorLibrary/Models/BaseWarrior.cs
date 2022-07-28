namespace WarriorLibrary;

public abstract class BaseWarrior
{
    private float _armor;

    protected BaseWarrior(float health, float armor)
    {
        Health = health;
        Armor = armor;
        Damage = SumArmorAndDamage - Armor;
    }

    protected BaseWarrior()
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
                _armor = 0;
            else
                _armor = value;
        }
    }

    public float Damage { get; set; }

    public bool HasAlive => Health > 0;


    private const uint SumArmorAndDamage = 20;

    public virtual void AddSuperPower(IWarriorSuperPower warriorSuperPower, uint countPower)
    {
        warriorSuperPower.AddSuperPower(this,countPower);
    }
    public float AttackPower()
    {
        if (Armor > 0)
            return Damage;
        if (Damage == 1)
            return 1;
        return --Damage;
    }
    public void Defence(float doneDamage)
    {
        if (Armor > 0)
        {
            var resultDamage = doneDamage / 2;
            if (resultDamage >= Armor)
            {
                Health -= resultDamage - Armor;
                Armor = 0;
                return;
            }
            Armor -= doneDamage / 2;
            Health -= doneDamage / 2;
            return;
        }
        Health -= doneDamage;
    }

    public override string ToString()
    {
        return $"{this.GetType()}\n Health: {Health}, Armor: {Armor}, Damage: {Damage}\n";
    }
}