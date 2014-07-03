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
    }
}