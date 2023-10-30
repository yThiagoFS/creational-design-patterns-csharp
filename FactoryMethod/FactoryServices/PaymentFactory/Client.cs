using FactoryMethod.FactoryServices.PaymentFactory.Enums;

namespace FactoryMethod.FactoryServices.PaymentFactory
{
    public static class Client
    {
        public static void ExecuteManufacturePayment()
        {
            var client = new SelectPaymentService();

            while (true)
            {
                Console.WriteLine("What type of service do you want to select? \n");
                Console.WriteLine("1 - Traditional");
                Console.WriteLine("2 - Credit");
                Console.WriteLine("3 - Premium");

                Console.Write("Type the number: ");

                var paymentType = (EPaymentType)int.Parse(Console.ReadLine());

                client.CreateService(paymentType);

                Console.WriteLine("Do you want to continue? \n");
                Console.WriteLine("1 - Yes");
                Console.WriteLine("2 - No");

                if (int.Parse(Console.ReadLine()) == 2)
                    break;
            }
        }
    }
}
