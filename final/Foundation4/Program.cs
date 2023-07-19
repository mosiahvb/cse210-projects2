using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running(new DateTime(2023, 07, 19), 30, 3.0);
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling(new DateTime(2023, 07, 19), 30, 6.0);
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming(new DateTime(2023, 07, 19), 30, 10);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
