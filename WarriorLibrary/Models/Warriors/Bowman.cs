namespace WarriorLibrary;

public class Bowman: BaseWarrior
{
    public Bowman() : base(100,2)
    {
    }

    public override string ToString()
    {
        return "Bowman: " + base.ToString();
    }
}