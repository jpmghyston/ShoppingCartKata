namespace ShoppingCart
{
    public interface ICart
    {
        string[] Items { get; set; }
    }

    public class Cart : ICart
    {
        public string[] Items { get; set; }
    }
}