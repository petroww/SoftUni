using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesForWalking = int.Parse(Console.ReadLine());
            int countOfWalking = int.Parse(Console.ReadLine());
            int tookCalories = int.Parse(Console.ReadLine());

            int minutesWalking = countOfWalking * minutesForWalking;
            int burnedCalories = minutesWalking * 5;
            int CaloriesNeedToBeBurned = tookCalories * 50 / 100;

            if (burnedCalories >= CaloriesNeedToBeBurned)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
