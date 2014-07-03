namespace ShoppingCart.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CartTests
    {
        private Cart cart;

        [SetUp]
        public void SetUp()
        {
            cart = new Cart();
        }
    }
}