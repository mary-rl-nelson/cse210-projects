using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();
        Console.WriteLine("1: Generate a random scripture");
        Console.WriteLine("2: Enter a scripture yourself");
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
            scripture = InputScripture.GetScriptureFromUser();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords(3);

            if (scripture.IsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplay());
                Console.WriteLine("\nAll words are hidden. Great job!");
                break;
            }
        }
    }
}
