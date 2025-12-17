using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("14135 champions dr", "Houston", "TX", 77069, "USA");
        Customer customer1 = new Customer("Mary Frazier", address1);

        Order order1 = new Order(customer1);
        order1.AddProductToList(new Product("Buffalo Cat Food", "A15243", 55, 1));
        order1.AddProductToList(new Product("Tofu Cat Litter", "C672A", 22, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order1.GetPriceTotal():0.00}");
        Console.WriteLine();

        Address address2 = new Address("123 jmapple Marie", "Berlin", "Berlin", 892321, "Germany");
        Customer customer2 = new Customer("Mary Frazier", address2);

        Order order2 = new Order(customer2);
        order2.AddProductToList(new Product("Tarte Mascara", "345Y", 29, 1));
        order2.AddProductToList(new Product("Nike Sweater", "T674MN", 40, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order2.GetPriceTotal():0.00}");
        Console.WriteLine();

        Address address3 = new Address("501 W Island Rd", "Morgan", "UT", 84050, "United States of America");
        Customer customer3 = new Customer("Grandma Mudrow", address3);

        Order order3 = new Order(customer3);
        order3.AddProductToList(new Product("Chocolate Orange", "fs63Y", 4, 3));
        order3.AddProductToList(new Product("Cardigan", "T674MN", 25, 2));
        order3.AddProductToList(new Product("Air Freshner", "7ry#4", 3, 3));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order3.GetPriceTotal():0.00}");
    }
}
