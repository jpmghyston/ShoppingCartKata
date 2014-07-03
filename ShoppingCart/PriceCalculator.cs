namespace ShoppingCart
{
    using System;

    public interface IPriceCalculator
    {
        int CalculatePrice();
    }

    public class PriceCalculator : IPriceCalculator
    {
        private readonly ICart cart;

        public PriceCalculator(ICart cart)
        {
            this.cart = cart;
        }

        public int CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}