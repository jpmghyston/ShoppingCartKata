namespace ShoppingCart
{
    using System;

    internal interface IShopItemList
    {
        ShopItem GetItemBySKU(string SKU);
    }

    public class ShopItemList : IShopItemList
    {
        public ShopItem GetItemBySKU(string SKU)
        {
            throw new NotImplementedException();
        }
    }
}