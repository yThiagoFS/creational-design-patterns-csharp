using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class TuesdayFridayTraining : ITraining
    {
        public TuesdayFridayTraining() => Console.WriteLine("Tuesday and Friday training: ");

        public void GetTraining() { }
    }
}
