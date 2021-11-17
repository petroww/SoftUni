using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<int>> pointByStudents = new SortedDictionary<string, List<int>>();

            SortedDictionary<string, List<string>> nameAndCourse = new SortedDictionary<string, List<string>>();


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "exam finished")
                {
                    break;
                }
                string[] cmArgs = line
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                if (cmArgs[1] == "banned")
                {
                    pointByStudents.Remove(cmArgs[0]);
                    nameAndCourse.Remove(cmArgs[0]);
                    continue;
                }
                string name = cmArgs[0];
                string course = cmArgs[1];
                int point = int.Parse(cmArgs[2]);

                if (pointByStudents.ContainsKey(name))
                {
                    pointByStudents[name].Add(point);
                    
                }
                else
                {
                    pointByStudents.Add(name, new List<int>() { point });
                    
                }

                if (nameAndCourse.ContainsKey(course))
                {
                    nameAndCourse[course].Add(name);
                }
                else
                {
                    nameAndCourse.Add(course, new List<string>() { name });
                }


            }

            Dictionary<string, List<int>> sorted = pointByStudents
                .OrderByDescending(n => n.Value.Max())
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, List<string>> sortedCourses = nameAndCourse
                .OrderByDescending(n => n.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");
            foreach (var students in sorted)
            {
                
                Console.WriteLine($"{students.Key} | {students.Value.Max()}");
                
            }
            Console.WriteLine("Submissions:");
            foreach (var item in sortedCourses)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
            }




        }
    }
}
