using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;




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
        for (int i = 5; i>0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }


    public void QuitActivity()
    {
        Console.WriteLine("Thank you for using the Mindfulness program today. See you again soon. Goodbye!");
    }

}