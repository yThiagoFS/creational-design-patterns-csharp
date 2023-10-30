using AbstractFactory.Product.Contracts;

namespace AbstractFactory.Product.Implementations
{
    public class MondayWednesdayDiet : IDiet
    {
        public void GetDiet() => Console.WriteLine("Monday and Wednesday diet: ");
    }
}
