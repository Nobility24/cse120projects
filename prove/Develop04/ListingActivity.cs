// This is the listing Activity
class ListingActivity : Activity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity") { }

    public void StartActivity()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = listPrompts[random.Next(listPrompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // pause for 3 seconds to think about the prompt

        Console.WriteLine("Start listing your items...");

        // Allowing the user to list items for the specified duration
        Thread.Sleep(duration * 1000);

        Console.WriteLine($"You listed {duration} items!");

        DisplayEndingMessage();
    }

    protected override string GetActivityDescription()
    {
        return "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}
