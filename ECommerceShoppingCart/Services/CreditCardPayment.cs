using ECommerceShoppingCart.Interfaces;

namespace ECommerceShoppingCart.Services
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Logic to process credit card payment
            Console.WriteLine($"Credit Card Payment of {amount:C} processed.");
        }
    }
}
