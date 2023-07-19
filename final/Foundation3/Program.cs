using System;

class Program
{
    static void Main()
    {
        Event lectureEvent = new Lecture("Lecture on Improving résumés", "Introduction for Résumé building on careers in software engineering", DateTime.Now.AddDays(7), new Address("5032 W short st.", "rexburg", "ID", "USA"), "Jack Ryan", 100);
        Event receptionEvent = new Reception("Wedding reception", "Celebrating with the Valdez family", DateTime.Now.AddDays(14), new Address("11234 small lane Av.", "Bosi", "ID", "USA"), "valdezfam@gmail.com");
        Event outdoorEvent = new OutdoorGathering("Morgan Wallen concert", "Amazing music in outdoor area", DateTime.Now.AddDays(21), new Address("1326 N main St.", "Boston", "MA", "USA"), "Mostly sunny with a chance of rain");

        Console.WriteLine();
        Console.WriteLine("Standard details:");
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full details:");
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short details:");
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard details:");
        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full details:");
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short details:");
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard details:");
        Console.WriteLine(outdoorEvent.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full details:");
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short details:");
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}
