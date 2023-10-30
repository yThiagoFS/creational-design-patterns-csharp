using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class ThursdaySaturdayDiet : IDiet
    {
        public void GetDiet() => Console.WriteLine("Thursday and saturday diet: ");
    }
}
