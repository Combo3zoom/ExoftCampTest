namespace WarriorLibrary;

public class Swordmen:BaseWarrior
{
    public Swordmen() : base(100,10)
    {
    }

    public override string ToString()
    {
        return "Swordmen - " + base.ToString();
    }
}