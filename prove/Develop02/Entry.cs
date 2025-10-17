using System.IO; 

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;


    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entry = entryText;
    }


    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }

    public string HoldData()
    {
        return ($"{_date}|{_prompt}|{_entry}");
    }


    public static Entry LoadData(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }

}