namespace WarriorLibrary;

public class ArmorSuperPower: IWarriorSuperPower
{
    public void AddSuperPower(BaseWarrior baseWarrior, uint countPower)
    {
        baseWarrior.Armor += countPower;
    }
}