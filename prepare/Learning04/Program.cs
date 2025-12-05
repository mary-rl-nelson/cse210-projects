using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("jake", "English"); 
        Console.WriteLine(assignment1.GetAssignmentInfo());

       // WritingAssignment assignment2 = new WritingAssignment();
       // Console.WriteLine(assignment2.GetWritingInformation());

       // WritingAssignment assignment3 = new WritingAssignment("aubrey", "history", "Rome's Fall");
      //  Console.WriteLine(assignment3.GetWritingInformation());

        WritingAssignment assignment4 = new WritingAssignment("cheese", "biology", "If pigs could fly");
        Console.WriteLine(assignment4.GetAssignment());

        MathAssignment assignment5 = new MathAssignment();
        Console.WriteLine(assignment5.GetHomeworkList());

        MathAssignment assignment6 = new MathAssignment("alex", "geometry", "radius","8-12");
        Console.WriteLine(assignment6.GetHomeworkList());
        Console.WriteLine(assignment6.GetSection());
    }
}