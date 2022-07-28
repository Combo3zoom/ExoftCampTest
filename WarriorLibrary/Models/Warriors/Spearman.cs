namespace WarriorLibrary;

public class Spearman: BaseWarrior
{
    public Spearman() : base(100,15)
    {
        Armor = 15;
    }
    public override string ToString()
    {
        return "Spearman - " + base.ToString();
    }
}