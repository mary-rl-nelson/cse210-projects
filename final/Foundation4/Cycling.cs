using System;

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(string date, int minutes, double speedMph) : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        double hours = GetLength() / 60;
        return _speedMph * hours;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        return 60 / _speedMph;
    }
}