class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What lessons did I learn for the future?",
            "Did I make anyone's life better today?",
            "What is it that I can be grateful of from today?"
        };

        int randomIndex = new Random().Next(prompts.Length);
        string prompt = prompts[randomIndex];

        Console.WriteLine($"Prompt: {prompt}");
        string response = Console.ReadLine();

        entries.Add(new Entry(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter a filename to save the journal:");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();

        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string prompt = parts[0];
                string response = parts[1];
                DateTime date = DateTime.Parse(parts[2]);

                entries.Add(new Entry(prompt, response) { Date = date });
            }
        }
    }
}
