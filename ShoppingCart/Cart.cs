namespace ShoppingCart
{
    using System.Collections.Generic;

    public interface ICart
    {
        IEnumerable<string> Items { get; set; }
    }

    public class Cart : ICart
    {
        public IEnumerable<string> Items { get; set; }
    }
}