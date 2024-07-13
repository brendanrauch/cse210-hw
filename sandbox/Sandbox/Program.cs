using System;
using System.Data;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");




        // Employee employee = new Employee("Bob",40,23.77);
        // Console.WriteLine($"{employee.GetName()} is due {employee.GetPay()}");

        ConstructionWorker constructionWorker = new ConstructionWorker("Betty", 40,35.88);
        // Console.WriteLine($"{constructionWorker.GetName()} is due {constructionWorker.GetPay()}");

        Docter docter = new Docter("Belinda", 240000.99);
        // Console.WriteLine($"{docter.GetName()} is due {docter.GetPay()}");
        List<Employee> employees = new List<Employee>{};
        // employees.Add(employee);
        employees.Add(constructionWorker);
        employees.Add(docter);

        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.GetName()} is due: {e.GetPay()} Insureance Cost due: {e.InsuranceCost()}");
        }


    // //     Circle myCircle = new Circle(10);
    // //     Console.WriteLine($"{myCircle.GetArea()}");

    // //     Circle unitCircle = new Circle(1);
    // //     Console.WriteLine($"{unitCircle.GetCircumfrence()}");
    // //     Console.WriteLine($"{unitCircle.GetDiameter()}");

    //     Person person1 = new Person("Bob", "Billy", 24, 210);
    //     Console.WriteLine(person1.PersonInforamtion());

    //     Fireman fireman = new Fireman("Emt and Paramaedic", "Bob", "Billy", 24, 210);
    //     Console.WriteLine(fireman.PersonInforamtion());
    //     Console.WriteLine(fireman.FiremanInformation());



    }
}