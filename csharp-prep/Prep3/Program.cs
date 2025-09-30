using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        Console.Write("What is you guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        if (userGuess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (userGuess < magicNumber)
        {
            Console.WriteLine("Higher");
        }


        while (magicNumber != userGuess)
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        }

        Console.WriteLine("You guessed it!!");
    }
}