using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class TuesdayFridayDiet : IDiet
    {
        public void GetDiet() => Console.WriteLine("Tuesday and friday diet: ");
    }
}
