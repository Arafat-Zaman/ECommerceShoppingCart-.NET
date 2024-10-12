using ECommerceShoppingCart.Interfaces;

namespace ECommerceShoppingCart.Services
{
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Logic to process PayPal payment
            Console.WriteLine($"PayPal Payment of {amount:C} processed.");
        }
    }
}
