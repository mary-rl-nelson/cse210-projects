using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter = "";
        string sign = "";

        //Determining last digit and assigning a sign.
        if (int.TryParse(gradePercentage, out int number))
        {
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        //Determining a letter grade.
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade > 70)
        {
            letter = "C";
        }

        else if (grade > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        //Printing statements and if they failed or passed.

        if (letter == "A" && sign == "+")
        {
            Console.Write($"You finished the course with {grade}%, giving you the passing grade of {letter} . Congratulations!!");
        }
        else if (letter == "F" && sign == "+" || sign == "-")
        {
            Console.Write($"Unfortunately, you scored {grade}%, {70 - grade}% below passing, with the grade of {letter}. We encourage you to keep studying and to try again.");
        }
        else if (grade >= 70)
        {
            Console.Write($"You finished the course with {grade}%, giving you the passing grade of {sign + letter} . Congratulations!!");
        }
        else
        {
            Console.Write($"Unfortunately, you scored {grade}%, {70 - grade}% below passing, with the grade of {sign + letter}. We encourage you to keep studying and to try again.");
        }

    }   
}