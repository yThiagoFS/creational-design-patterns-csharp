using FactoryMethod.FactoryServices.PaymentFactory.Contracts;

namespace FactoryMethod.FactoryServices.PaymentFactory.Implementations
{
    public class PremiumPayment : IPaymentService
    {
        public PremiumPayment() => Console.WriteLine("Premium payment service created successfully");

        public void ExecutePaymentService()
        {
            // Implement the logic for the premium payment service
        }
    }
}
