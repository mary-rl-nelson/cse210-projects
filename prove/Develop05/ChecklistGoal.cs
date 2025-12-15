using System;

public class CheckListGoal : Goal
{
    private int _completedAmount;
    private int _target;
    private int _bonus;

    public CheckListGoal(
        string name,
        DateTime dateTime,
        string description,
        int points,
        int bonus,
        int target,
        int amountCompleted = 0)
        : base(name, dateTime, description, points)
    {
        _bonus = bonus;
        _target = target;
        _completedAmount = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _completedAmount++;

        if (_completedAmount == _target)
        {
            _dateCompleted = DateTime.Now;
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _completedAmount >= _target;
    }

    public override string GetStatus()
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

        return $"[{box}] {_name}: {_description} | Date Created: {_dateTime:MM/dd/yyyy} | Worth: {_points} | Progress: {_completedAmount}/{_target}{completedText}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{_name}|{_dateTime}|{_description}|{_points}|{_bonus}|{_target}|{_completedAmount}";
    }
}
