using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
    //     int x = 10;
    //     if (x>0)
    //     {
    //         Console.WriteLine(x);
    //     }

    //     int userage = 0;
    //     do
    //     {
    //         Console.WriteLine("Please input your age(0-120)");
    //         userage = int.Parse(Console.ReadLine());

    //     }  while (userage < 0 || userage > 120);
    // }
}