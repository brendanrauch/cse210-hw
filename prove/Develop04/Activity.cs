using System;
using System.Threading;

abstract class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        PerformActivity();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    protected abstract void PerformActivity();

    protected void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            //AI helped with the spinner. this code cycle throughs the diffrents objects and replaces them witht the next one pausing for a bit giving the spinner look.
            foreach (var frame in new[] { "|", "/", "-", "\\" })
            {
                Console.Write($"\r{frame}");
                Thread.Sleep(200);
            }
        }
        Console.Write("\r ");
    }

    protected void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\r ");
    }

    public void ShowCountdownWithMessage(int duration, string message)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{message}{i}");
            Thread.Sleep(1000);
        }
        Console.Write($"\r{message} ");
    }

    public void ShowSpinnerWithMessage(int duration, string message)
    {
        int initialCursorLeft = Console.CursorLeft;
        int initialCursorTop = Console.CursorTop;

        for (int i = 0; i < duration; i++)
        {
            foreach (var frame in new[] { "|", "/", "-", "\\" })
            {
                //the program was freaking out when i would go into half screen so ai helped with the setcursor position to solve the isssue. this code will keep the cursor to the left so the the \r doesnt mess up
                Console.SetCursorPosition(initialCursorLeft, initialCursorTop);
                Console.Write($"\r{message}{frame}");
                Thread.Sleep(200);
            }
        }
        Console.SetCursorPosition(initialCursorLeft, initialCursorTop);
        Console.Write($"\r{message} ");
    }
}
