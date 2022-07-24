namespace WarriorLibrary;

public class HealthSuperPower:IWarriorSuperPower
{
    public void AddSuperPower(Warrior warrior, uint countPower)
    {
        warrior.Health += countPower;
    }
}