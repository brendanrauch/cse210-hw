using System;

// Program class
class Program
{
    static void Main(string[] args)
    {
        Reference _reference = null;
        string _verse = null;

        while (_reference == null)
        {
            Console.WriteLine("Choose a scripture to memorize:");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.Write("Enter 1 or 2: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _reference = new Reference("John", 3, 16);
                    _verse = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
                    break;
                case "2":
                    _reference = new Reference("Proverbs", 3, 5, 6);
                    _verse = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }

        Scripture _scripture = new Scripture(_reference, _verse);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(_scripture);
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("The program has eneded. Please come again.");
                break;
            }

            _scripture.HideRandomWords(3);

            if (_scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(_scripture);
                Console.WriteLine("All words are hidden. The program will now end.");
                break;
            }
        }
    }
}