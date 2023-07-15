using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("22367 Lane Park rd.", "nampa", "ID", "USA");
        Address address2 = new Address("6553 N Oak Ave", "Toronto", "Ontario", "Canada");

        Customer customer1 = new Customer("Benjamin, the American", address1);
        Customer customer2 = new Customer("Terrence, the Canadian", address2);

        Product product1 = new Product("USA jujitsu Rashguard", "RG43376", 55.95, 2);
        Product product2 = new Product("CA jujitsu Rashguard", "RG32679", 50.75, 3);
        Product product3 = new Product("Athletic shorts", "AS45111", 35.55, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
        Console.WriteLine();
    }
}