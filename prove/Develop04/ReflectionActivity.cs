using System;

class ReflectingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you felt the Holy Ghost"
    };

    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "How did it make you feel",
        "Would you do it again",
        "Have you told someone else about it."

    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        ShowCountdownWithMessage(5, "You may begin in: ");
        Console.Clear();

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string question = Questions[random.Next(Questions.Length)];
            Console.Write(question);
            ShowSpinnerWithMessage(8, question);
            Console.WriteLine("");

            
        }
        Console.WriteLine("");
    }
}
