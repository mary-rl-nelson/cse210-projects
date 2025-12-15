using System;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected DateTime _dateTime;
    protected string _description;
    protected int _points;

    protected DateTime? _dateCompleted = null;

    public Goal(string name, DateTime dateTime, string description, int points)
    {
        _name = name;
        _dateTime = dateTime;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public DateTime? GetDateCompleted()
    {
        return _dateCompleted;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetStatus()
    {
        string box;
        string completedText = "";

        if (IsComplete())
        {
            box = "X";
        }
        else
        {
            box = " ";
        }

        if (IsComplete() && _dateCompleted != null)
        {
            completedText = $" | Completed On: {_dateCompleted:MM/dd/yyyy}";
        }

        return $"[{box}] {_name}: {_description} | Date Created: {_dateTime:MM/dd/yyyy} | Worth: {_points}{completedText}";
    }
}

