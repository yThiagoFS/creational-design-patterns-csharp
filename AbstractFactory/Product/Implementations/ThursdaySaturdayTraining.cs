using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class ThursdaySaturdayTraining : ITraining
    {
        public ThursdaySaturdayTraining() => Console.WriteLine("Thursday and Saturday training: ");
        public void GetTraining() { }
    }
}
