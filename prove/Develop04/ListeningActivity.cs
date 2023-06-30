using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "when are you the most happy?",
        "what are your favorite foods?",
        "who made you laugh today?",
        "what are you looking forward to tomorrow?",
        "who do you look up to you?"
    };

    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Here's a prompt for you:");
        string randomPrompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine();

        Console.Write("Press Enter to start the listing activity...");
        Console.ReadLine();
        Console.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int durationInSeconds = GetDuration();
        int itemCount = 0;

        Console.WriteLine("Start listing items!");

        Thread.Sleep(3000);
        Console.Clear();

        while (stopwatch.Elapsed.TotalSeconds < durationInSeconds)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            Console.Clear();

            if (!string.IsNullOrWhiteSpace(item))
                itemCount++;
        }

        stopwatch.Stop();

        Console.WriteLine($"You listed {itemCount} items.");
        showSpinner(5);

        DisplayEndingMessage();
    }
}
