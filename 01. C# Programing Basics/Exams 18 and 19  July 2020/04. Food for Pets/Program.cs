using System;

namespace FoodPerPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double startedFood = double.Parse(Console.ReadLine());

            double cookies = 0;
            double dogAte = 0;
            double catAte = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogEatFood = double.Parse(Console.ReadLine());
                double catEatFood = double.Parse(Console.ReadLine());


                dogAte += dogEatFood;
                catAte += catEatFood;

                if (i % 3 == 0)
                {
                    double percentOfCookies = (dogEatFood + catEatFood) * 0.10; ;
                    cookies += percentOfCookies;
                }
            }

            double allEatenFood = dogAte + catAte;
            double eatenFood = allEatenFood / startedFood * 100;
            double eatenFoodByDog = dogAte / allEatenFood * 100;
            double eatenFoodByCat = catAte / allEatenFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{eatenFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{eatenFoodByDog:F2}% eaten from the dog.");
            Console.WriteLine($"{eatenFoodByCat:F2}% eaten from the cat.");
        }
    }
}
