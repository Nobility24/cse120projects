// Checklist goal class
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        completedCount = 0;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Console.WriteLine($"You recorded an event for the checklist goal: {Name}");
        Console.WriteLine($"You earned {points} points.");

        if (completedCount == targetCount)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal: {Name}");
            Console.WriteLine($"You earned an additional bonus of {points * targetCount} points.");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Completed {completedCount}/{targetCount} times - {Name}");
    }
}