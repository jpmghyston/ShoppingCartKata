namespace ShoppingCart.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class ShopItemTests
    {
        private ShopItem appleItem;
        private ShopItem cabbageItem;

        [SetUp]
        public void SetUp()
        {
            appleItem = new ShopItem("A99", 50, 3, 130);
            cabbageItem = new ShopItem("C40", 60, null, null);
        }

        [Test]
        public void Item_Returns_Correct_Price_For_One_Apple()
        {
            appleItem.Add();
            appleItem.GetTotalPrice().Should().Be(50);
        }

        [Test]
        public void Item_Returns_Correct_Price_For_Three_Apples()
        {
            for (var i = 0; i < 3; i++)
            {
                appleItem.Add();
            }

            appleItem.GetTotalPrice().Should().Be(130);
        }

        [Test]
        public void Item_Returns_Correct_Price_For_Five_Cabbages()
        {
            for (var i = 0; i < 5; i++)
            {
                cabbageItem.Add();
            }
            cabbageItem.GetTotalPrice().Should().Be(60 * 5);
        }
    }
}