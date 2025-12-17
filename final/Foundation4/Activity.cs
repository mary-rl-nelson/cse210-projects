using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMin;

    public Activity(string date, int lengthMin)
    {
        _date = date;
        _lengthMin = lengthMin;
    }

    public string GetDate() 
    {
        return _date;
    }

    public int GetLength()
    {
        return _lengthMin;
    }

    public abstract string GetName();
    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public virtual double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public string GetActivitySummary()
    {
        return $"{GetName()} | Date: {GetDate()} | {GetLength()} minutes\nDistance: {GetDistance()} miles\nSpeed: {GetSpeed()}mph\nPace: {GetPace()} minutes per mile\n";
    }
}
