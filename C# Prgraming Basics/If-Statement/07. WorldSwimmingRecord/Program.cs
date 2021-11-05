using System;

namespace WorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double TimeInSecoundFor1meter = double.Parse(Console.ReadLine());


            double delay = distanceInMeters / 15;
            int delay2 = (int)delay;

            double result = distanceInMeters * TimeInSecoundFor1meter;

            result = result + delay2 * 12.5;
            if (result < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", result);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", Math.Abs(result - record));
            }

        }
    }
}
