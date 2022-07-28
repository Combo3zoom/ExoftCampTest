namespace WarriorLibrary;

public class Crossbowman: BaseWarrior
{
    public Crossbowman() : base(100,6)
    {
    }
    public override string ToString()
    {
        return "Crossbowman - " + base.ToString();
    }
}