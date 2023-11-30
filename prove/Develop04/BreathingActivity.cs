// This is the breathing Activity
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity") { }

    public void StartActivity()
    {
        DisplayStartingMessage();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); // pause for 1 second
        }

        DisplayEndingMessage();
    }

    protected override string GetActivityDescription()
    {
        return "Relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}