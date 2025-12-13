using System;
using System.Buffers;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int score = 0;
        bool running = true;
        GoalFrameSaveLoad mGoals = new GoalFrameSaveLoad();

        Console.WriteLine("Welcome to Eternal Quest Program! We are excited to help you achieve your goals.");

        while (running)
        {
            Console.WriteLine($"You have {score} points.\n");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6.Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
           

            if (choice == "1")
            {
               mGoals.NewGoal();
            }

            else if (choice == "2")
            {
                mGoals.ListDetails();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter filename for goals: ");
                mGoals.Save(Console.ReadLine());
            }

            else if (choice == "4")
            {
                Console.WriteLine("Enter filename to load goals: ");
                mGoals.Load(Console.ReadLine());
            }
            
            else if (choice == "5")
            {
                mGoals.RecordEvent();
            }

            else if (choice == "6")
            {
                Console.WriteLine("Thank you for using the Eternal Quest program today. See you again soon. Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }    
    }
}

  
