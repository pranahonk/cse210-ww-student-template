using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Chicago", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("T-shirt", "TS01", 15.99, 2);
        Product product2 = new Product("Water Bottle", "WB02", 9.50, 1);
        Product product3 = new Product("Notebook", "NB03", 6.25, 3);
        Product product4 = new Product("Pencil Set", "PS04", 4.00, 4);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order 1
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display order 2
        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}