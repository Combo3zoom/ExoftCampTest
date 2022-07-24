namespace WarriorLibrary;

public static class SuperPowerGenerator
{
    private static int _counter;
    public static int CapacitySuperPower(int lowerNumber = 5, int upperNumber = 10)
    {
        return (DateTime.Now.Millisecond + _counter++) % (upperNumber-lowerNumber+1) + lowerNumber;
    }
}