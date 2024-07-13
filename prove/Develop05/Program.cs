
using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    private static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine($"Total Score: {goalManager.GetTotalScore()}");
            Console.WriteLine("");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ShowGoals();
                    break;
                case "3":
                    goalManager.SaveData();
                    break;
                case "4":
                    goalManager.LoadData();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}