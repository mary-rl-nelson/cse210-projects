using System;
public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

     public string GetStandardDetails()
    {
        return $"{GetTitle()}\n{GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress:\n{GetAddress().GetAddressLayout()}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {GetEventType()}\n{GetExtraInfo()}";
    }

    public string GetShort()
    {
        return $"{GetEventType()}: {_title} | ({_date})";
    }

    public abstract string GetEventType();

    public abstract string GetExtraInfo();

}