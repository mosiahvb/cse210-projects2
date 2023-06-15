using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("what is the Magic number 1-101");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("higher!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("lower!");
            }
            else
            {
                Console.WriteLine("You Guessed it!!!");
            }
        }
    }
}