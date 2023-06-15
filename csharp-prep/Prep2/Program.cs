using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("what Percent did you get in the class? ");
        string response = Console.ReadLine();
        int precent = int.Parse(response);
        string grade = "";

        if (precent >= 90)
        {
            grade = "A";
        }
        else if (precent >= 80)
        {
            grade = "B";
        }
        else if (precent >= 70)
        {
            grade = "c";
        }
        else if (precent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is a: {grade}!");

        if (precent > 60)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next Time");
        }
    }
}