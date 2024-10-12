namespace ECommerceShoppingCart.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ShoppingCart Cart { get; set; } = new ShoppingCart();
    }
}
