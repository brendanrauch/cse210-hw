
using System;
class Program
{
    private static List<string> Prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did you see the Lord in your life today?",
        "Did you spend any money today, if yes on what?",
        "Is there anything you need to do tomorrow you did not complete today?"
    };

    private Journal _journal;

    public Program()
    {
        _journal = new Journal();
    }

    public void WriteEntry()
    {
        var random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM-dd-yyyy");
        var entry = new JournalEntry(date, prompt, response);
        _journal.AddEntry(entry);
        Console.WriteLine("Entry saved!");
    }

    public void DisplayJournal()
    {
        _journal.DisplayEntries();
    }

    public void SaveJournal()
    {
        Console.Write("Enter file name to save journal: ");
        string filename = Console.ReadLine();
        _journal.WriteToFile(filename);
    }

    public void LoadJournal()
    {
        Console.Write("Enter file name to load journal: ");
        string filename = Console.ReadLine();
        _journal.ReadFromFile(filename);
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load a journal from a file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("Program Closed");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        var program = new Program();
        program.ShowMenu();
    }
}