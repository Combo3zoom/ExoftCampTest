namespace WarriorLibrary;

public class ArmorSuperPower: IWarriorSuperPower
{
    public void AddSuperPower(Warrior warrior, uint countPower)
    {
        warrior.Armor += countPower;
    }
}