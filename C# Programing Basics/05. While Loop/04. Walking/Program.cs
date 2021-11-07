using System;
using System.Reflection.Metadata;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumSteps = 0;

            int stepsToBeWalking = 10000;



            while (true)
            {
                string steps = Console.ReadLine();

                if (steps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    sumSteps += stepsToHome;
                    if (sumSteps >= stepsToBeWalking)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sumSteps - stepsToBeWalking} steps over the goal!");
                        break;
                    }
                    else
                        Console.WriteLine($"{stepsToBeWalking - sumSteps} more steps to reach goal.");
                    break;
                }
                else
                {
                    int Convert = int.Parse(steps);
                    sumSteps += Convert;

                    if (sumSteps >= stepsToBeWalking)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{sumSteps - stepsToBeWalking} steps over the goal!");
                        break;
                    }

                }



            }





        }
    }
}
