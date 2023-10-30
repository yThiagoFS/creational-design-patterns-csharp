using AbstractFactory.Manufacture.Contracts;
using AbstractFactory.Product.Implementations;

namespace AbstractFactory.Manufacture.Implementations
{
    public class MondayWednesdayFactory : IFactory
    {
        public MondayWednesdayFactory() => this.GetDailyRoutine();

        public void GetDailyRoutine()
        {
            var mondayWednesdayDiet = new MondayWednesdayDiet();
            var mondayWednesdayTraining = new MondayWednesdayTraining();

            mondayWednesdayDiet.GetDiet();
            mondayWednesdayTraining.GetTraining();
        }
    }
}
