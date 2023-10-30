using AbstractFactory.Manufacture.Contracts;
using AbstractFactory.Product.Implementations;

namespace AbstractFactory.Manufacture.Implementations
{
    public class TuesdayFridayFactory : IFactory
    {
        public TuesdayFridayFactory() => this.GetDailyRoutine();

        public void GetDailyRoutine()
        {
            var tuesdayFridayDiet = new TuesdayFridayDiet();
            var tuesdayFridayTraining = new TuesdayFridayTraining();

            tuesdayFridayDiet.GetDiet();
            tuesdayFridayTraining.GetTraining();
        }
    }
}
