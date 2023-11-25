// Class to represent the scripture itself
class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public List<ScriptureWord> Words { get; private set; }

    public Scripture(ScriptureReference reference, string[] words)
    {
        Reference = reference;
        Words = new List<ScriptureWord>();

        foreach (var word in words)
        {
            Words.Add(new ScriptureWord(word));
        }
    }

        public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }

    // Method to hide a few random words in the scripture
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(Words.Count);

            if (!Words[index].IsHidden)
            {
                Words[index].IsHidden = true;
                hiddenCount++;
            }
        }
    }

    // Method to check if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}

// Class to manage a library of scriptures
class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary(string filePath)
    {
        LoadScripturesFromFile(filePath);
    }

    // Load scriptures from a file
    private void LoadScripturesFromFile(string filePath)
    {
        scriptures = new List<Scripture>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                string reference = parts[0];
                string[] words = parts[1].Split(' ');

                scriptures.Add(new Scripture(new ScriptureReference(reference), words));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures from file: {ex.Message}");
        }
    }

    // Get a random scripture from the library
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}