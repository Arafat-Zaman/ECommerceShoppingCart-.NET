namespace ECommerceShoppingCart.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
