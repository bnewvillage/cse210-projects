using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetCurrentCustomer("John Smith", "32nd","New York City","New York","United States");
        order1.AddToCart("Shampoo", "22SHMP", 10,2);
        order1.AddToCart("Bread", "BRD19",15,3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Order order2 = new Order();
        order2.SetCurrentCustomer("Liam Connor", "St. Patty Avenue", "Dublin", "Leinster", "Ireland");
        order2.AddToCart("Tea", "T19TEA", 8, 5);
        order2.AddToCart("Scones", "SCN20", 12, 4);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());

    }
}