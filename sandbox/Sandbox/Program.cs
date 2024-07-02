using System;
using System.Data;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

    //     Circle myCircle = new Circle(10);
    //     Console.WriteLine($"{myCircle.GetArea()}");

    //     Circle unitCircle = new Circle(1);
    //     Console.WriteLine($"{unitCircle.GetCircumfrence()}");
    //     Console.WriteLine($"{unitCircle.GetDiameter()}");

        Person person1 = new Person("Bob", "Billy", 24, 210);
        Console.WriteLine(person1.PersonInforamtion());

        Fireman fireman = new Fireman("Emt and Paramaedic", "Bob", "Billy", 24, 210);
        Console.WriteLine(fireman.PersonInforamtion());
        Console.WriteLine(fireman.FiremanInformation());
    }
}