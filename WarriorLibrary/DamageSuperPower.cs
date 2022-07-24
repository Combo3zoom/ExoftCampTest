namespace WarriorLibrary;

public class DamageSuperPower:IWarriorSuperPower
{
    public void AddSuperPower(Warrior warrior, uint countPower)
    {
        warrior.Damage += countPower;
    }
}