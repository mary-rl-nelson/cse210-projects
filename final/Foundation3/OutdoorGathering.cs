using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public override string GetEventType()
    {
        return "Outdoor Event";
    }

    public override string GetExtraInfo()
    {
        return $"Weather: {_weather}";
    }
}