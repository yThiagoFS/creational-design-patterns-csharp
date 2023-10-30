using FactoryMethod.FactoryServices.PaymentFactory.Contracts;

namespace FactoryMethod.FactoryServices.PaymentFactory.Implementations
{
    public class CreditPayment : IPaymentService
    {
        public CreditPayment() => Console.WriteLine("Credit payment service created successfully");

        public void ExecutePaymentService()
        {
            // Implement the logic for the credit payment service
        }
    }
}
