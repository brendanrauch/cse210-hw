using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("25678 Main St", "Rancho Cucamonga", "CA", "USA");
        Address address2 = new Address("762 Red Keep", "KingsLanding", "ON", "Canada");

        Customer customer1 = new Customer("John Rich", address1);
        Customer customer2 = new Customer("Jophery Waters", address2);

        Product product1 = new Product("Sword", "ID001", 14.99, 5);
        Product product2 = new Product("Armor", "ID002", 29.99, 2);
        Product product3 = new Product("Dragon", "ID003", 49.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("");
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine("------------------");
        }
    }
}