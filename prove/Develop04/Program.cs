using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Console.WriteLine("Welcome to Mindfulness! We are excited to help assist in your journey to relaxation and mindfulness");

        while (running)
        {
    
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
           

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.BeginProgram();
                activity.RunBreathing();
            }

            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.BeginProgram ();
            }

            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.BeginProgram();
            }
            
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness program today. See you again soon. Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
    }
}