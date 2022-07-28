namespace WarriorLibrary;

public class HealthSuperPower:IWarriorSuperPower
{
    public void AddSuperPower(BaseWarrior baseWarrior, uint countPower)
    {
        baseWarrior.Health += countPower;
    }
}