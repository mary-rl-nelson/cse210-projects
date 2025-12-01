using System;

public class InputScripture
{
    public static Scripture GetScriptureFromUser()
    {
        Console.Write("Enter the book (e.g., 'Alma'): ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter (number): ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the starting verse (number): ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("Is there an ending verse? (y/n): ");
        string hasEndVerse = Console.ReadLine().Trim().ToLower();

        Refer reference;

        if (hasEndVerse == "y")
        {
            Console.Write("Enter the ending verse (number): ");
            int endVerse = int.Parse(Console.ReadLine());

            reference = new Refer(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Refer(book, chapter, startVerse);
        }

        Console.WriteLine("Enter the scripture content:");
        string content = Console.ReadLine();

        return new Scripture(reference, content);
    }
}