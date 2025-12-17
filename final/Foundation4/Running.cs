using System;

public class Running : Activity
{
    private double _miles;

    public Running(string date, int minutes, double miles) : base(date, minutes)
    {
        _miles = miles;
    }

    public double GetMiles()
    {
        return _miles;
    }

    public override string GetName()
    {
        return "Running";
    } 
    public override double GetDistance()
    {
        return _miles;
    }
}
