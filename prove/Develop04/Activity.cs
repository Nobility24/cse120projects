using System;
using System.Threading;

// This is the base class for all activities
class Activity
{
    protected int duration;
    protected string activityName;

    public Activity(string name)
    {
        activityName = name;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {activityName}!");
        Console.WriteLine($"This activity will help you {GetActivityDescription()}");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Get ready to begin in 5 seconds...");
        Thread.Sleep(5000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You have completed {activityName} for {duration} seconds.");
        Thread.Sleep(2000);
    }

    protected virtual string GetActivityDescription()
    {
        return "Perform this activity to improve your well-being.";
    }
}
