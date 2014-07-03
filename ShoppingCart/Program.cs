namespace ShoppingCart
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var priceCalculator = new PriceCalculator();

            Console.WriteLine("What would you like to buy?");
            var items = Console.ReadLine() ?? "";
            var cart = new Cart { Items = items.Split(',') };
            var price = priceCalculator.CalculatePrice(cart);
            Console.WriteLine("That will cost you {0}.", price);
        }
    }
}