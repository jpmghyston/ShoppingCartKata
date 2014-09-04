namespace ShoppingCart.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class CartTests
    {
        private Cart cart;

        [SetUp]
        public void SetUp()
        {
            cart = new Cart();
        }

        [Test]
        public void Cart_returns_items_assigned_to_it()
        {
            //Given
            cart.Items = "A99,B15,C40,T34".Split(',');

            //When
            var firstItem = cart.Items.First();

            //Then
            firstItem.Should().Be("A99");
        }
    }
}