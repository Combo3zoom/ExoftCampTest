namespace WarriorLibrary;

public static class SuperPowerGenerator
{
    private static int _counter;
    public static uint CapacitySuperPower(uint lowerNumber = 5, uint upperNumber = 10)
    {
        return (uint) ((DateTime.Now.Millisecond + _counter++) % (upperNumber-lowerNumber+1) + lowerNumber);
    }
}