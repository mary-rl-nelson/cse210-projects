using System;

class Program
{
    static void Main(string[] args)
    //Exceeding Requirements: Made it so the same questions and prompts wouldn't appear until all the questions and prompts had been used.
    //Exceeding Requirements Cont.: Made it so you could display the most recent Listing Activity Entries.
    {
        bool running = true;
        ListingActivity lastListingActivityResults = null;
        Console.WriteLine("Welcome to Mindfulness! We are excited to help assist in your journey to relaxation and mindfulness");

        while (running)
        {
    
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View the Last Listing Activity Entries");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
           

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.BeginProgram();
                activity.RunBreathing();
                activity.EndingMessage();
            }

            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.BeginProgram();
                activity.RunReflecting();
                activity.EndingMessage();
            }

            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.BeginProgram();
                activity.RunListing();
                activity.EndingMessage();
                lastListingActivityResults = activity;
            }

            else if (choice == "4")
            {
                if (lastListingActivityResults != null)
                {
                    lastListingActivityResults.DisplayList();
                }
                else
                {
                    Console.WriteLine("You have not completed a Listing Activity yet. Try again after completion of Listing Activity.");
                }
            }
            
            else if (choice == "5")
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
}
