namespace ShoppingCart
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IPriceCalculator
    {
        int CalculatePrice();
    }

    public class PriceCalculator : IPriceCalculator
    {
        private readonly ICart cart;

        private readonly List<ShopItem> itemList;

        public PriceCalculator(ICart cart)
        {
            this.cart = cart;
            itemList = new List<ShopItem>
                       {
                           new ShopItem("A99", 50, 3, 130),
                           new ShopItem("B15", 30, 2, 45),
                           new ShopItem("C40", 60),
                           new ShopItem("T34", 99)
                       };
        }

        public int CalculatePrice()
        {
            foreach (var item in cart.Items)
            {
                itemList.Find(listItem => listItem.SKU == item).Add();
            }
            return itemList.Sum(item => item.GetTotalPrice());
        }
    }
}