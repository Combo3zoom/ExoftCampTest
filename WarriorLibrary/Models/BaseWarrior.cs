using Microsoft.VisualBasic.CompilerServices;

namespace WarriorLibrary;

public abstract class BaseWarrior
{
    private float _armor;
    private float _health;
    private float _damage;

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


    public float Health
    {
        get => _health;
        set => _health = value;
    }

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

    public float Damage
    {
        get => _damage;
        set
        {
            if (value <= 1)
                _damage = 1;
            else
                _damage = value;
        }
    }

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
        return $"Health: {Health}, Armor: {Armor}, Damage: {Damage}\n";
    }

    public static BaseWarrior operator +(BaseWarrior firstBaseWarrior, BaseWarrior secondBaseWarrior)
    {
        firstBaseWarrior.Health += secondBaseWarrior.Health;
        firstBaseWarrior.Armor += secondBaseWarrior.Armor;
        firstBaseWarrior.Damage += secondBaseWarrior.Damage;
        return firstBaseWarrior;
    }
    public static BaseWarrior operator -(BaseWarrior firstBaseWarrior, BaseWarrior secondBaseWarrior)
    {
        firstBaseWarrior.Health -= secondBaseWarrior.Health;
        firstBaseWarrior.Armor -= secondBaseWarrior.Armor;
        firstBaseWarrior.Damage -= secondBaseWarrior.Damage;
        return firstBaseWarrior;
    }
    public static bool operator ==(BaseWarrior firstBaseWarrior, BaseWarrior secondBaseWarrior)
    {
        return firstBaseWarrior.Health == secondBaseWarrior.Health && firstBaseWarrior.Armor == secondBaseWarrior.Armor
                                                                   && firstBaseWarrior.Damage == secondBaseWarrior.Damage;
    }

    public static bool operator !=(BaseWarrior firstBaseWarrior, BaseWarrior secondBaseWarrior)
    {
        return !(firstBaseWarrior.Health == secondBaseWarrior.Health && firstBaseWarrior.Armor == secondBaseWarrior.Armor
                                                                   && firstBaseWarrior.Damage == secondBaseWarrior.Damage);
    }
}