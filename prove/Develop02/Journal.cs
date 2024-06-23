
using System;




public class Journal
{
    public List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._prompt}");
                Console.WriteLine($"Response: {entry._response}\n");
            }
        }
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal saved!");
    }

    public void ReadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                JournalEntry entry = new JournalEntry(date, prompt, response);
                this.AddEntry(entry);
            }
            Console.WriteLine("Journal loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}


  
  