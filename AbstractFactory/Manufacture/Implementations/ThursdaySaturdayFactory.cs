using AbstractFactory.Manufacture.Contracts;
using AbstractFactory.Product.Implementations;

namespace AbstractFactory.Manufacture.Implementations
{
    public class ThursdaySaturdayFactory : IFactory
    {
        public ThursdaySaturdayFactory() => this.GetDailyRoutine();

        public void GetDailyRoutine()
        {
            var thursdaySaturdayDiet = new ThursdaySaturdayDiet();
            var thursdaySaturdayTraining = new ThursdaySaturdayTraining();

            thursdaySaturdayDiet.GetDiet();
            thursdaySaturdayTraining.GetTraining();
        }
    }
}
