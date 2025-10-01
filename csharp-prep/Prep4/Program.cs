using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        double sum = 0;
        

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

        }
        foreach (int num in numbers)
        {
            count++;
            if (count == numbers.Count)
            {
                Console.WriteLine(num); // Last item — no comma
            }
            else
            {
                Console.WriteLine(num + ", ");
            }
        }

        foreach (int value in numbers)
        {
            sum += value;
        }
        
        int largestNumber = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }

        int countNumbers = numbers.Count;
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / countNumbers;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}