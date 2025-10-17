using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptList;
    private Random _rand;

    public PromptGenerator()
    {
        _rand = new Random();
        _promptList = new List<string>();
        _promptList.Add("Who was the most interesting person I interacted with today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over today, what would it be?");
        _promptList.Add("What was I grateful for today?");
        _promptList.Add("What is one thing I learned today and how can I apply it to my life?");
        _promptList.Add("What made me smile today?");
        _promptList.Add("How was I strengthened today? ");
        _promptList.Add("If I could have done anything I wanted today, what would it be and why?");
    }

    public string GeneratePrompt()
    {
        int index = _rand.Next(_promptList.Count);
        return _promptList[index];
    }
}
