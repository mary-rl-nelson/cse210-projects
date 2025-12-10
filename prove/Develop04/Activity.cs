using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;




    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;    
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }


    public string GetDescription()
    {
        return _description;
    }


    public void BeginProgram()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How many seconds would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Take a few seconds to prepare to begin.");
        for (int i = 3; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

        public void Timer()
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);    
    }

    public void EndingMessage()
    {
        Console.WriteLine($"Good Job! ");
        for (int i = 3; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

}