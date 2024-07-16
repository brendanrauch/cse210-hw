using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Activity> activities = new Dictionary<string, Activity>
        {
            { "1", new BreathingActivity() },
            { "2", new ReflectingActivity() },
            { "3", new ListingActivity() }
        };

        while (true)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            if (activities.ContainsKey(choice))
            {
                Console.Clear();
                activities[choice].Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
