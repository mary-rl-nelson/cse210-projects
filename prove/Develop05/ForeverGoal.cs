using System;
using System.Collections.Generic;
using System.IO;

public class ForeverGoal : Goal
{
    public ForeverGoal(string name, DateTime dateTime, string description, int points)
        : base(name, dateTime, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ForeverGoal|{_name}|{_dateTime}|{_description}|{_points}";
    }
}
