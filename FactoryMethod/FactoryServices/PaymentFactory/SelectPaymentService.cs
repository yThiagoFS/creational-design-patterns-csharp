using FactoryMethod.FactoryServices.PaymentFactory.Contracts;
using FactoryMethod.FactoryServices.PaymentFactory.Enums;
using FactoryMethod.FactoryServices.PaymentFactory.Implementations;

namespace FactoryMethod.FactoryServices.PaymentFactory
{
    public class SelectPaymentService : PaymentFactory
    {
        public override IPaymentService CreateService(EPaymentType paymentType)
            => paymentType switch
            {
                EPaymentType.CreditPayment => new CreditPayment(),
                EPaymentType.TraditionalPayment => new TraditionalPayment(),
                EPaymentType.PremiumPayment => new PremiumPayment(),
                _ => throw new NotImplementedException(),
            };
    }
}
