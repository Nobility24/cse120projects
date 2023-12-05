using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        // Example goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10));

        // Record events
        foreach (var goal in goals)
        {
            goal.RecordEvent();
        }

        // Display progress
        Console.WriteLine("\nYour goals and progress:");
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }
}