using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 45, 10.0); 
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 60, 30); 

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        Console.Clear();

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
