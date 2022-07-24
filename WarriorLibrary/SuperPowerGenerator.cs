namespace WarriorLibrary;

public static class SuperPowerGenerator
{
    public static int CapacitySuperPower(int lowerNumber = 5, int upperNumber = 10)
    {
        return (DateTime.Now.Millisecond % (upperNumber-lowerNumber+1)) + lowerNumber;
    }
}