using System;
using System.Runtime.CompilerServices;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment() : base()
    {
        _title = "I am blue";
    }

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title =  title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Name: {_name}, Topic: {_topic}, Title: {_title}";
    }
    
    public string GetAssignment()
    {
        return $"{GetAssignmentInfo()}, Title: {_title}";
    }

}