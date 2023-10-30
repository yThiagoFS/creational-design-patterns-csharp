using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class MondayWednesdayTraining : ITraining
    {
        public MondayWednesdayTraining() => Console.WriteLine("Monday and Wednesday training: ");

        public void GetTraining() { }
    }
}
