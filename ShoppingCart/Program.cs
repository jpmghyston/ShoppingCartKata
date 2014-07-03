namespace ShoppingCart
{
    using System;

    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("What would you like to buy?");
            var items = Console.ReadLine() ?? "";
            var cart = new Cart { Items = items.Split(',') };
            var priceCalculator = new PriceCalculator(cart);
            var price = priceCalculator.CalculatePrice();
            Console.WriteLine("That will cost you {0}.", price);
        }
    }
}