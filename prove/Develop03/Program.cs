using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scriptures.txt"; // Replace with your file path

        ScriptureLibrary library = new ScriptureLibrary(filePath);

        do
        {
            Scripture scripture = library.GetRandomScripture();

            Console.Clear();
            Console.WriteLine(scripture);

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);

        } while (true);
    }
}