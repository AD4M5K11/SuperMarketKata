using System;
using System.Collections.Generic;

namespace SupermarketKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Item> Items = new Dictionary<string, Item>
            {
                { "A", new Item("A", 50, "3 for 130") },
                { "B", new Item("B", 30, "2 for 45") },
                { "C", new Item("C", 20) },
                { "D", new Item("D", 15) }
            };

            ICheckout checkout = new Checkout(Items);
            Console.WriteLine("What Items would you like?");
            Console.ReadLine();

            Console.WriteLine("Your total has come to " + checkout.GetTotalPrice());
        }
    }
}
