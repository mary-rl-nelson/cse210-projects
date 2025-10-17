using System.Runtime.InteropServices.Marshalling;
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void _displayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void _saveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.HoldData());
            }
        }
    }

    public void _loadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = Entry.LoadData(line);
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded successfully.");
    }

    public void _quitJournal()
    {
        Console.WriteLine("Thank you for using the journal today. Comeback tomorrow and update us on your day! Goodbye!");
    }
}