using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetExtraInfo()
    {
        return $"Speaker: {_speaker}\nCapacity: {_capacity}";
    }

}