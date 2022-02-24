using System;

static class AssemblyLine
{
    private const int carPerHour = 221;
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.0; // 0%
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1; // 100%
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9; // 90%
        }
        else if (speed == 9)
        {
            return 0.8; // 80%
        }
        else
        {
            return 0.77; // 77%
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        return carPerHour * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
