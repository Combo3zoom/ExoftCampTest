namespace WarriorLibrary;

public class DamageSuperPower:IWarriorSuperPower
{
    public void AddSuperPower(BaseWarrior baseWarrior, uint countPower)
    {
        baseWarrior.Damage += countPower;
    }
}