using System.Collections.Generic;

namespace ECommerceShoppingCart.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
