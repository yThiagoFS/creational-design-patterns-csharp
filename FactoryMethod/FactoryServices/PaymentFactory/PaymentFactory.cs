using FactoryMethod.FactoryServices.PaymentFactory.Contracts;
using FactoryMethod.FactoryServices.PaymentFactory.Enums;

namespace FactoryMethod.FactoryServices.PaymentFactory
{
    public abstract class PaymentFactory
    {
        public abstract IPaymentService CreateService(EPaymentType paymentType);
    }
}
