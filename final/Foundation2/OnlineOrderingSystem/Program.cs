using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating products
        Product product1 = new Product("Widget", "W123", 10.00m, 2);
        Product product2 = new Product("Gadget", "G456", 15.00m, 1);
        Product product3 = new Product("Thingamajig", "T789", 7.50m, 3);

        // Creating orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product1, product3 });

        // Displaying order details
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}
