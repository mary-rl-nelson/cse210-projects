using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;

    private List<string> _unusedPrompts;
    private List<string> _unusedQuestions;

    private Random _rand;
    private String _prompt;


    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _rand = new Random();

        _promptList = new List<string>();
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");

       
        _questionList = new List<string>();
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");

        _unusedPrompts = new List<string>(_promptList);
        _unusedQuestions = new List<string>(_questionList);

    }

    public string GeneratePrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_promptList);
        }

        int index = _rand.Next(_unusedPrompts.Count);
        string selected = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        return selected;
    }

    public string GenerateQuestions()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questionList);
        }

        int index = _rand.Next(_unusedQuestions.Count);
        string selected = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);

        return selected;
    }

    public void RunReflecting()
    {
        Timer();
        _prompt = GeneratePrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine("When you have a specific experience in mind, press Enter to continue.");
        Console.ReadLine();

        while(DateTime.Now < _endTime)
        {
            string s = GenerateQuestions();
            Console.WriteLine(s);
           for (int loop = 0; loop < 5 && DateTime.Now < _endTime; loop++)
            {
                Console.Write(".");
                Thread.Sleep(1000); 
            }
            Console.WriteLine();
        }
    }
}