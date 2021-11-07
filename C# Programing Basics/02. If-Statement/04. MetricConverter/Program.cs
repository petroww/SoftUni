using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            string from = Console.ReadLine();
            string to = Console.ReadLine();



            if (from == "m")
            {
                if (to == "mm")
                {
                    Console.WriteLine($"{num * 1000:f3}");
                }
                else if (to == "cm")
                {
                    Console.WriteLine($"{num * 100:f3}");
                }
            }

            else if (from == "mm")
            {
                if (to == "m")
                {
                    Console.WriteLine($"{num / 1000:f3}");
                }
                else if (to == "cm")
                {
                    Console.WriteLine($"{num / 10:f3}");
                }
            }

            else if (from == "cm")
            {
                if (to == "m")
                {
                    Console.WriteLine($"{num / 100:f3}");
                }
                else if (to == "mm")
                {
                    Console.WriteLine($"{num * 10:f3}");
                }
            }

        }
    }
}
