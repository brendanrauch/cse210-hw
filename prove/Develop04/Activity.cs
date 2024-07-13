
abstract class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {Name} Activity.");
        Console.WriteLine(Description);
        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        PerformActivity();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name} Activity.");
        ShowSpinner(3);
    }

    protected abstract void PerformActivity();

    protected void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            foreach (var frame in new[] { "|", "/", "-", "\\" })
            {
                Console.Write($"\r{frame}");
                Thread.Sleep(200);
            }
        }
        Console.Write("\r ");
    }
}