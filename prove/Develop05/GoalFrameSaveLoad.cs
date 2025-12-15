using System.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

public class GoalFrameSaveLoad
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int _level = 1;
    private const int _pointsPerLevel = 1000; 

    private string GetLevelTitle(int level)
    {
        if (level == 1)
        {
            return "Baby Capybara";
        } 

        if (level == 2)
        {
            return "Knee-High Capybara";
        }

        if (level == 3)
        {
            return "Awkobara";
        } 

        if (level == 4)
        {
            return "Muscle Bera";
        }
        
        if (level == 5)
        {
            return "Unicap";
        }

        if (level == 6)
        {
            return "Perfect Angel Bera";
        }

        return "Mythical Eternal Capybara";

        
    }

    public void ShowScore()
    {
        Console.WriteLine($"You have {_score} points\nLevel {_level}: {GetLevelTitle(_level)}\n");
    }

    public void NewGoal()
    {
        Console.WriteLine("Goal Option Menu");
        Console.WriteLine("1. Simple: One time goal");
        Console.WriteLine("2. Eternal: Never ends");
        Console.WriteLine("3. Checklist Goal: Complete multiple times");
        Console.Write("Choose a goal type:");
        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Goal Description: ");
        string desc = Console.ReadLine();

        Console.Write("Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        DateTime now = DateTime.Now;

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, now, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new ForeverGoal(name, now, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times would you like to complete your goal: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("How many bonus points when for completing goal?: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new CheckListGoal(name, now, desc, points, bonus, target));
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void ListDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("It looks like you haven''t added any goals yet.");
            return;
        }

        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("It looks like you haven't added any goals yet.");
            return;
        }

        List<Goal> _availableGoals = new List<Goal>();

        for (int i = 0; i < _goals.Count; i++)
        {
            if (!_goals[i].IsComplete())
            {
                _availableGoals.Add(_goals[i]);
            }
        }

        if (_availableGoals.Count == 0)
        {
            Console.WriteLine("All goals are completed! Great job!");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _availableGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_availableGoals[i].GetName()}");
        }

        Console.Write("Enter number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _availableGoals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        int earned = _availableGoals[choice].RecordEvent();
        _score += earned;

        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine($"You earned {earned} points!");
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / _pointsPerLevel) + 1;

        while (newLevel > _level)
        {
            _level++;
            Console.WriteLine($"LEVEL UP! You are now Level {_level}: {GetLevelTitle(_level)}");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine("Saved!");
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (line == "")
            {
                continue;
            }

            string[] parts = line.Split("|");
            string type = parts[0];

            if (parts.Length < 5)
            {
                continue;
            }

            string name = parts[1];
            DateTime date = DateTime.Parse(parts[2]);
            string desc = parts[3];
            int points = int.Parse(parts[4]);

            if (type == "SimpleGoal")
            {
                if (parts.Length < 6) continue;
                bool done = bool.Parse(parts[5]);
                _goals.Add(new SimpleGoal(name, date, desc, points, done));
            }
            else if (type == "ForeverGoal")
            {
                _goals.Add(new ForeverGoal(name, date, desc, points));
            }
            else if (type == "CheckListGoal")
            {
                if (parts.Length < 8) continue;
                int bonus = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int amount = int.Parse(parts[7]);

                _goals.Add(new CheckListGoal(name, date, desc, points, bonus, target, amount));
            }
        }

        _level = (_score / _pointsPerLevel) + 1;

        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Console.WriteLine("Loaded!");
        Console.WriteLine($"Current Level {_level}: {GetLevelTitle(_level)}");
    }
}