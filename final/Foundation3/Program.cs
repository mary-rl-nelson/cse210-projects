using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        List<Event> eventsList = new List<Event>();

        Address address1 = new Address(501, "west island rd", "morgan", "Utah", 84050);
        Address address2 = new Address(14135, "champions dr", "Houston", "Texas", 77069);
        Address address3 = new Address(6619, "Cypress point dr", "Houston", "Texas", 77069);

        Event lecture1 = new Lecture("President Oaks", 2000, "The life of Christ", "An inspiration meeting for young adults.", "12/25/2025", "7pm CST", address1);
        eventsList.Add(lecture1);

        Event reception1 = new Reception("maryrosellalouisenelson@gmail.com", "Mary & Ryan's Reception", "Come celebrate the marriage of Ryan and Mary Frazier.", "01/04/2025", "5pm", address2);
        eventsList.Add(reception1);

        Event outdoorGathering1 = new OutdoorGathering("78 degrees with clouds, 15% chance of rain.", "Ward Iceskating", "Come bring your friends and familly for fun, hot chocolate, and company.", "12/30/2026", "12 pm", address3);
        eventsList.Add(outdoorGathering1);

    foreach (Event e in eventsList)
        {
            Console.WriteLine(e.GetEventType());
            Console.WriteLine();
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("Short Description: ");
            Console.WriteLine(e.GetShort());
            Console.WriteLine("----");
            Console.WriteLine();
        }

    }
}