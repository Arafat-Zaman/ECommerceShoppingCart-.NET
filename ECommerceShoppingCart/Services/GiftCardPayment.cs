using ECommerceShoppingCart.Interfaces;

namespace ECommerceShoppingCart.Services
{
    public class GiftCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            // Logic to process gift card payment
            Console.WriteLine($"Gift Card Payment of {amount:C} processed.");
        }
    }
}
