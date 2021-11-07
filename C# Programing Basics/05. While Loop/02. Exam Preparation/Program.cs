using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string nameTask = Console.ReadLine();
            int counterBadGrades = 0;
            int sumGrades = 0;
            int counterTasks = 0;
            string lastTask = "";
            bool isTheGradeBad = false;

            while (nameTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                counterTasks++;

                if (grade <= 4)
                {
                    counterBadGrades++;

                    if (counterBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                        isTheGradeBad = true;
                        break;
                    }
                }

                lastTask = nameTask;
                nameTask = Console.ReadLine();
            }


            if (isTheGradeBad == false)
            {
                double average = sumGrades * 1.0 / counterTasks;
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {counterTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}