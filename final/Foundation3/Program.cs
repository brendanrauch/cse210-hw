using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1256 Main St", "Ontario", "CA", "USA");
        Address address2 = new Address("6548", "Smalltown", "ON", "Canada");
        Address address3 = new Address("890 Oak St", "China", "TX", "USA");

        Lecture lecture = new Lecture("Intro to Programming", "Learn the basics of functions", new DateTime(2023, 10, 15), "10:00 AM", address1, "John Smith", 100);
        Reception reception = new Reception("Wedding Event", "Meet and greet with the new couple", new DateTime(2023, 11, 5), "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Company Picnic", "Fun outdoor activities and food", new DateTime(2023, 9, 25), "12:00 PM", address3, "Sunny with some Clouds");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
