using System;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;


            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum < 200)
                {
                    p1++;
                }
                else if (inputNum >= 200 && inputNum <= 399)
                {
                    p2++;
                }
                else if (inputNum >= 400 && inputNum < 600)
                {
                    p3++;
                }
                else if (inputNum >= 600 && inputNum < 800)
                {
                    p4++;
                }
                else if (inputNum >= 800)
                {
                    p5++;
                }
            }
            double p1Result = p1 / n * 100;
            double p2Result = p2 / n * 100;
            double p3Result = p3 / n * 100;
            double p4Result = p4 / n * 100;
            double p5Result = p5 / n * 100;

            Console.WriteLine($"{p1Result:F2}%");
            Console.WriteLine($"{p2Result:F2}%");
            Console.WriteLine($"{p3Result:F2}%");
            Console.WriteLine($"{p4Result:F2}%");
            Console.WriteLine($"{p5Result:F2}%");


        }
    }
}
