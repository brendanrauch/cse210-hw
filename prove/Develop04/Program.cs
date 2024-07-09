using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int response = 0;
        while(response < 1 || response > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            try
            {
                response = int.Parse(Console.ReadLine());
            
            }
            catch
            {
                Console.WriteLine("Input an integer between 1 and 4");
            }
        }



    }
}