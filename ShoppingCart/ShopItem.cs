namespace ShoppingCart
{
    public interface IShopItems
    {
        void Add();
        int GetTotalPrice();
    }

    public class ShopItem : IShopItems
    {
        private readonly int UnitPrice;
        private readonly int? offerNumber;
        private readonly int? offerPrice;
        private int occurances;

        public ShopItem(string sku, int unitPrice, int? offerNumber = null, int? offerPrice = null)
        {
            SKU = sku;
            UnitPrice = unitPrice;
            occurances = 0;
            this.offerNumber = offerNumber;
            this.offerPrice = offerPrice;
        }

        public string SKU { get; private set; }

        public void Add()
        {
            occurances++;
        }

        public int GetTotalPrice()
        {
            if (offerNumber != null)
            {
                var offerCost = (occurances / offerNumber) * offerPrice;
                var otherCost = occurances % offerNumber * UnitPrice;
                return (int)(otherCost + offerCost);
            }
            return occurances * UnitPrice;
        }
    }
}