using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("\nCreate a new goal:");
                Console.Write("Enter goal title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Select goal type:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");

                Console.Write("Enter your choice (1-3): ");
                string goalTypeInput = Console.ReadLine();

                if (goalTypeInput == "1")
                {
                    Console.Write("Enter points for completing the goal: ");
                    int points = Convert.ToInt32(Console.ReadLine());
                    goals.Add(new SimpleGoal(title, points));
                    Console.WriteLine("Simple goal created successfully");
                }
                else if (goalTypeInput == "2")
                {
                    Console.Write("Enter points for each event recording: ");
                    int pointsPerEvent = Convert.ToInt32(Console.ReadLine());
                    goals.Add(new EternalGoal(title, pointsPerEvent));
                    Console.WriteLine("Eternal goal created successfully");
                }
                else if (goalTypeInput == "3")
                {
                    Console.Write("Enter points for each event recording: ");
                    int pointsPerEvent = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter target count for completing the checklist: ");
                    int targetCount = Convert.ToInt32(Console.ReadLine());
                    goals.Add(new ChecklistGoal(title, pointsPerEvent, targetCount));
                    Console.WriteLine("Checklist goal created successfully");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Goal creation canceled");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("\nRecord an event:");

                if (goals.Count == 0)
                {
                    Console.WriteLine("No goals available. please create a goal first");
                }
                else
                {
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Goal goal = goals[i];
                        Console.WriteLine($"{i + 1}. {goal.Title} - {(goal.IsComplete ? "Completed" : "Not Completed")}");
                    }

                    Console.Write("Enter the goal number to record an event: ");
                    string goalNumberInput = Console.ReadLine();

                    if (int.TryParse(goalNumberInput, out int goalNumber))
                    {
                        if (goalNumber > 0 && goalNumber <= goals.Count)
                        {
                            Goal selectedGoal = goals[goalNumber - 1];
                            selectedGoal.RecordEvent();
                            Console.WriteLine("Event recorded successfully");
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid Goal number");
                    }
                }
            }
            else if (input == "3")
            {
                Console.WriteLine("\nGoals:");

                if (goals.Count == 0)
                {
                    Console.WriteLine("No goals available. please create a goal first");
                }
                else
                {
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Goal goal = goals[i];
                        Console.WriteLine($"{goal.Title} - {(goal.IsComplete ? "Completed" : "Not Completed")}");
                    }
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again");
            }
        }
    }
}