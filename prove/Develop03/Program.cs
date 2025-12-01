using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1: Generate a random scripture");
        Console.WriteLine("2: Enter a scripture");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();

        Scripture scripture;

        if (choice == "1")
        {
            GenerateScripture generator = new GenerateScripture();
            scripture = generator.ScriptureGenerate();
        }

        else if (choice == "2")
        {
            scripture = CreateScriptureFromUserInput();
        }

        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Refer refer = new Refer(scripture);
        string referenceText = refer.GetReference();

        Console.Clear();
        Console.WriteLine("Here is your scripture:");
        Console.WriteLine();
        Console.WriteLine(referenceText);
        Console.WriteLine(scripture._content);
        Console.WriteLine();
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
    static Scripture CreateScriptureFromUserInput()
    {
        Console.Write("Enter the book (EX: Alma): ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter (number): ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the starting verse (number): ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("Is there an ending verse? (y/n): ");
        string hasEndVerse = Console.ReadLine().ToLower();

        int? endVerse = null;
        if (hasEndVerse == "y")
        {
            Console.Write("Enter the ending verse (number): ");
            endVerse = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the scripture text:");
        string content = Console.ReadLine();

        return new Scripture
        {
            _book = book,
            _chapter = chapter,
            _verse = startVerse,
            _verse2 = endVerse,
            _content = content
        };
    }
}