using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (num <= 100)
            {
                bonusPoints += 5;

            }
            else if (num > 100 && num < 1000)
            {
                bonusPoints = num * 20 / 100;
            }
            else if (num > 1000)
            {
                bonusPoints = num * 10 / 100;
            }

            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(num + bonusPoints);
        }
    }
}
