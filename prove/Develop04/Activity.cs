using System.Diagnostics;
class Activity
{
    private string description, name;
    static int spinnerCounter,duration;

    public Activity()
    {
        spinnerCounter = duration = 0;
    }

    public void SetActivityName(string _activityName)
    {
        name = _activityName;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Weclome to the {name}");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.Write("how long would you like for your session?");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        showSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds to the {name}.");
        showSpinner(7);
    }

    public void showSpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >=1; i--)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.Write(" ");
    }
}