namespace ShoppingCart.Tests
{
    using FakeItEasy;
    using FluentAssertions;
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class PriceCalculatorTests
    {
        private PriceCalculator calculator;
        private ICart cart;

        [SetUp]
        public void SetUp()
        {
            cart = A.Fake<ICart>();
            calculator = new PriceCalculator(cart);
        }

        [Test]
        public void Empty_cart_should_cost_nothing()
        {
            // Given
            A.CallTo(() => cart.Items).Returns(Enumerable.Empty<string>());

            // When
            var price = calculator.CalculatePrice();

            // Then
            price.Should().Be(0);
        }

        [Test]
        public void Cart_with_one_apple_returns_50()
        {
            // Given
            cart.Items = "A99".Split(',');

            // When
            var price = calculator.CalculatePrice();

            // Then
            price.Should().Be(50);
        }

        [Test]
        public void Cart_with_many_items_returns_price()
        {
            // Given
            cart.Items = "A99,A99,A99,A99,B15,B15,B15,C40,C40,T34".Split(',');

            // When
            var price = calculator.CalculatePrice();

            //Then
            price.Should().Be(130 + 50 + 45 + 30 + 120 + 99);
        }
    }
}