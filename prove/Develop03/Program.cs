using System;

public class Program
{
    public static void Main()
    {
        Reference reference = new Reference("2 NEPHI", 28, 30);
        string scriptureText = "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Navigation instructions");
            Console.WriteLine("\nPress Enter to hide two words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                return;
            }
            else
            {
                scripture.HideTwoWords();
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Great job! Keep up the practice!");
    }
}
