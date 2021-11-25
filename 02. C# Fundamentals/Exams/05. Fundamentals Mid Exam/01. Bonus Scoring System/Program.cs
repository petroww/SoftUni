using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double countStudent = int.Parse(Console.ReadLine());

            double countLectures = int.Parse(Console.ReadLine());

            double initialBonus = int.Parse(Console.ReadLine());

            double theMostAtendenc = 0;
            if (countStudent == 0 || countLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }
            for (int i = 0; i < countStudent; i++)
            {

                int attendances = int.Parse(Console.ReadLine());
                if (attendances > theMostAtendenc)
                    theMostAtendenc = attendances;

            }

            double maxBonus = theMostAtendenc / countLectures * (5 + initialBonus);


            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {theMostAtendenc} lectures.");
        }
    }
}
