// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded an event for the eternal goal: {Name}");
        Console.WriteLine($"You earned {points} points.");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[ ] {Name}");
    }
}