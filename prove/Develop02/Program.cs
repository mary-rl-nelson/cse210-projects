using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string date = DateTime.Now.ToShortDateString();
                string prompt = promptGen.GeneratePrompt();
                Console.WriteLine("\nPrompt: " + prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal._displayAllEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal._saveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal._loadFromFile(filename);
            }
            else if (choice == "5")
            {
                journal._quitJournal();
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}