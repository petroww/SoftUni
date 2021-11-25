using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            // we have 3 employee working

            int firstServedStudentPerHour = int.Parse(Console.ReadLine());
            int secondServedStudentPerHour = int.Parse(Console.ReadLine());
            int thirthServedStudentPerHour = int.Parse(Console.ReadLine());
            int askingStudents = int.Parse(Console.ReadLine());



            double hours = 0;

            while (askingStudents > 0)
            {

                int studentsForAHour = firstServedStudentPerHour + secondServedStudentPerHour + thirthServedStudentPerHour;

                if (askingStudents < studentsForAHour)
                {

                    hours += (studentsForAHour / askingStudents) * 10;
                    break;
                }
                else
                {
                    askingStudents -= studentsForAHour;
                    hours += 60;
                }
                if ((hours / 60) % 4 == 0)
                {
                    hours += 60;
                }


            }
            double totalTime = hours / 60;


            Console.WriteLine($"Time needed: {Math.Ceiling(totalTime)}h.");


        }
    }
}
