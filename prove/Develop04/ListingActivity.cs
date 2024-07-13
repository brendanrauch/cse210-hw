class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);
        Console.WriteLine("You may begin in:");
        ShowSpinner(3);
        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        List<string> items = new List<string>();
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items!");
    }
}