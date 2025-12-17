using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }
    
    public override string GetName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        double miles = (_laps * 50 / 1000.0) * 0.62;
        return miles;
    }
}