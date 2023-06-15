using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("what is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"my name is {lastname}, {firstname} {lastname}");
    }
}
