using Microsoft.AspNetCore.Mvc;
using ECommerceShoppingCart.Models;
using ECommerceShoppingCart.Interfaces;
using ECommerceShoppingCart.Services;

namespace ECommerceShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        private Customer _customer;

        public ShoppingCartController()
        {
            // For demo purposes, instantiate a customer
            _customer = new Customer { Name = "John Doe" };
        }

        public IActionResult Index()
        {
            return View(_customer.Cart);
        }

        [HttpPost]
        public IActionResult AddProduct(int productId)
        {
            // Simulating adding a product
            var product = new Product { Id = productId, Name = "Sample Product", Price = 10.00M };
            _customer.Cart.AddProduct(product);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Checkout(string paymentType)
        {
            IPaymentMethod paymentMethod;

            // Choosing payment method based on the input
            switch (paymentType)
            {
                case "CreditCard":
                    paymentMethod = new CreditCardPayment();
                    break;
                case "PayPal":
                    paymentMethod = new PayPalPayment();
                    break;
                case "GiftCard":
                    paymentMethod = new GiftCardPayment();
                    break;
                default:
                    return BadRequest("Invalid payment method.");
            }

            // Process payment
            paymentMethod.ProcessPayment(_customer.Cart.GetTotalPrice());

            // Simulate order creation
            var order = new Order
            {
                Customer = _customer,
                TotalAmount = _customer.Cart.GetTotalPrice()
            };

            // Clear the cart after checkout
            _customer.Cart.Products.Clear();

            return RedirectToAction("Index");
        }
    }
}
