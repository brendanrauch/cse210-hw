using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random random = new Random();
         int magicNumber = random.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // string magicNumberInput = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberInput);
        Console.WriteLine("Guess what the magic number is");
        int guess;

        do 
        {

            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess == magicNumber )
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (guess != magicNumber);
    }
}