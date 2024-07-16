using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountdownWithMessage(5, "Breathe in...");
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            ShowCountdownWithMessage(4, "Now breathe out...");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    
}
