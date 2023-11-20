using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournalToFile();
                    break;
                case 4:
                    journal.LoadJournalFromFile();
                    break;
                case 0:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}