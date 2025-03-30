using System;
using System.Collections.Generic;

class Program {
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "CA", "USA");
        Address address2 = new Address("456 Main St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Dave Johnson", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        Product product1 = new Product("Laptop", 101, 1000, 2);
        Product product2 = new Product("Mouse", 102, 25, 1);
        Product product3 = new Product("Keyboard", 103, 50, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()} ");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()} ");
    }
}