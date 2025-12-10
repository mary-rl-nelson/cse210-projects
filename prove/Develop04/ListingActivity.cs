using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _listPrompts;
    private Random _rand;
    private String _prompt;
    private List<string> _itemsListed;

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _rand = new Random();

        _listPrompts = new List<string>();
        _listPrompts.Add("Who are people that you appreciate?");
        _listPrompts.Add("What are personal strengths of yours?");
        _listPrompts.Add("Who are people that you have helped this week?");
        _listPrompts.Add("When have you felt the Holy Ghost this month?");
        _listPrompts.Add("Who are some of your personal heroes?");

        _itemsListed = new List<string>();
    }

    public string GenerateListingPrompt()
    {
        int index = _rand.Next(_listPrompts.Count);
        return _listPrompts[index];
    }

    public void RunListing()
    {
        Timer();
        _prompt = GenerateListingPrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine();
        Console.WriteLine("Take a moment to begin thinking about the prompt");

        for (int p = 5; p>0; p--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        } 

        Console.WriteLine("Begin listing: ");

        while(DateTime.Now < _endTime)
        {

            string item = Console.ReadLine();
            _itemsListed.Add(item);

        }

        
        Console.WriteLine($"You listed {_itemsListed.Count} items!");
    }

    public void DisplayList()
    {
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine("You listed the following: ");
        foreach (string item in _itemsListed)
        {
            Console.WriteLine("> " + item);
        }
    }
}