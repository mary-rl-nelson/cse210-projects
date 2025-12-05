using System.Security.Cryptography;
using System;
using System.Diagnostics.Tracing;

public class Assignment
{
    protected string _name = "";
    protected string _topic ="";

    public Assignment()
    {
        _name = "none";
        _topic = "idk";
    }

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }


    public string GetAssignmentInfo()
    {
        return $"Name: {_name}, Topic: {_topic}";
    }

}

