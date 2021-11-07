using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            decimal allPresentationScore = 0.00M;
            decimal scoreCounter = 0M;
            while (true)
            {
                string presentation = Console.ReadLine();
                decimal presentationScore = 0.00M;
                if (presentation == "Finish")
                {
                    decimal scoreSum = allPresentationScore / scoreCounter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:F2}.");
                    break;
                }
                for (int i = 0; i < judges; i++)
                {
                    decimal score = decimal.Parse(Console.ReadLine());
                    presentationScore += score;
                    allPresentationScore += score;
                    scoreCounter++;
                }
                decimal presentationSingleScore = presentationScore / judges;
                Console.WriteLine($"{presentation} - {presentationSingleScore:F2}.");
            }

        }
    }
}