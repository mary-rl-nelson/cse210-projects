using System;
using System.IO;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, DateTime dateTime, string description, int points, bool isComplete = false) : base(name, dateTime, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;
        _dateCompleted = DateTime.Now;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_dateTime}|{_description}|{_points}|{_isComplete}";
    }
}