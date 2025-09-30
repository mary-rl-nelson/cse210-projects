using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber = 1;
        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());

        while (userGuess != magicNumber)
        {
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            guessNumber++;
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"You guessed it!! It took you {guessNumber} tries.");
    }

}