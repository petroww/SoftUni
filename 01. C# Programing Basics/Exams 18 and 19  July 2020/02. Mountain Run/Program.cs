using System;

namespace MounthainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSecond = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsFor1meter = double.Parse(Console.ReadLine());

            double NeedTobeRunInSeconds = meters * secondsFor1meter;
            double addTime = Math.Floor(meters / 50);
            addTime *= 30;
            double sumTime = NeedTobeRunInSeconds + addTime;

            if (sumTime < recordInSecond)
                Console.WriteLine($"Yes! The new record is {sumTime:F2} seconds.");



            else if (sumTime >= recordInSecond)
                Console.WriteLine($"No! He was { sumTime - recordInSecond:F2} seconds slower.");
        }
    }
}
