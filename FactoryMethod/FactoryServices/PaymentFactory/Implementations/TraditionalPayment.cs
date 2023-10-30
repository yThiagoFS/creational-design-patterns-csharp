using FactoryMethod.FactoryServices.PaymentFactory.Contracts;

namespace FactoryMethod.FactoryServices.PaymentFactory.Implementations
{
    public class TraditionalPayment : IPaymentService
    {
        public TraditionalPayment() => Console.WriteLine("Traditional payment service created successfully");

        public void ExecutePaymentService()
        {
            // Implement the logic for the traditional payment service
        }
    }
}
