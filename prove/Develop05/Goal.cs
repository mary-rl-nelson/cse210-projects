using System;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;


    public string GetName()
    {
        return _name;    
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetStatus()
    {
            
    }

    public string GetStringRepresentation()
    {
        
    }




}