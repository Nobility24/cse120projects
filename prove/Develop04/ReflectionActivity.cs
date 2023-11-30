// Reflection Activity
class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this different than the other times when you were not successful?",
        "What is your favourite thing about this experience?",
        "What can you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experince in mind in the future?"

    };

    public ReflectionActivity() : base("Reflection Activity") { }

    public void StartActivity()
    {
        DisplayStartingMessage();

        Random random = new Random();

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(1000);

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(1000);

                //Console.Write("\b \b");
                //Console.Write("-")
                // Displaying spinner or other animation
            }
        }

        DisplayEndingMessage();
    }

    protected override string GetActivityDescription()
    {
        return "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}