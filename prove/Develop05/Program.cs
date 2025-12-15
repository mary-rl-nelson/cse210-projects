using System;
using System.Buffers;
using System.Collections.Generic;

using System;
//Made it so user can level up. Made it so it would show the date it was created on. 
//If goal is complete, I made it so it doesn't show up in the list of items when you push record but still will show up in list of goals.

class Program
{
    static void Main(string[] args)
    {
        GoalFrameSaveLoad mGoal = new GoalFrameSaveLoad();

        Console.WriteLine("Welcome to Eternal Progression Quest Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            mGoal.ShowScore();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                mGoal.NewGoal();
            }

            else if (choice == "2")
            {
                mGoal.ListDetails();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                mGoal.Save(Console.ReadLine());
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                mGoal.Load(Console.ReadLine());
            }

            else if (choice == "5")
            {
                mGoal.RecordEvent();
            }

            else if (choice == "6")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        Console.WriteLine("Great job at working on your goals today! Have a great day, goodbye!");
    }
}
