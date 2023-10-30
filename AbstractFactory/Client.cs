using AbstractFactory.Enums;
using AbstractFactory.Manufacture.Contracts;
using AbstractFactory.Manufacture.Implementations;

namespace AbstractFactory
{
    public static class Client
    {
        public static void Execute()
        {
            IFactory client;
            
            while (true)
            {
                Console.WriteLine("Select the day that you want to consult your rotine: \n");
                Console.WriteLine("1 - Monday and Wed.");
                Console.WriteLine("2 - Tuesday and Friday.");
                Console.WriteLine("3 - Thursday and Saturday.");

                Console.WriteLine("Type the number:  ");

                var choice = (EDailyRoutine)int.Parse(Console.ReadLine());

                client = choice switch
                {
                    EDailyRoutine.MondayWednesday => new MondayWednesdayFactory(),
                    EDailyRoutine.TuesdayFriday => new TuesdayFridayFactory(),
                    EDailyRoutine.ThursdaySaturday => new ThursdaySaturdayFactory(),
                    _ => throw new NotImplementedException()
                };

                Console.WriteLine("Do you want to continue? \n");
                Console.WriteLine("1 - Yes");
                Console.WriteLine("2 - No");

                if (int.Parse(Console.ReadLine()) == 2)
                    break;
            }
        }
    }
}
