namespace ShoppingCart
{
    using System;

    public class PriceCalculator
    {
        private readonly Cart cart;

        public PriceCalculator(Cart cart)
        {
            this.cart = cart;
        }

        public int CalculatePrice()
        {
            throw new NotImplementedException();
        }
    }
}