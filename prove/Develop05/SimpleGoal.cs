// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You completed the simple goal: {Name}");
        Console.WriteLine($"You earned {points} points.");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[X] {Name}");
    }
}