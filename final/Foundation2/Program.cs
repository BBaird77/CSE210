using System;
using System.Collections.Generic;

class Program {
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");

        Customer customer1 = new Customer("John Smith", address1);
       
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", 101, 1000, 2);
        Product product2 = new Product("Mouse", 102, 25, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()} ");
    }
}