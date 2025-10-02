using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int year;
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromtUserNumber();
        PromptUserBirthYear(out year);
        int currentYear = GetCurrentYear();
        int age = GetAge(currentYear, year);
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared, age);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromtUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int GetCurrentYear()
    {
        DateTime currentTime = DateTime.Now;
        int currentYear = currentTime.Year;
        return currentYear;
    }

    static int GetAge(int currentYear, int year)
    {
        int age = currentYear - year;
        return age;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name, int numberSquared, int age)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}.");
        Console.WriteLine($"{name}, you will turn {age}.");
    }
}
