using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = parts[0];
                string name = parts[1];

                if (studentsByCourses.ContainsKey(course))
                {
                    studentsByCourses[course].Add(name);
                }
                else
                {
                    studentsByCourses.Add(course, new List<string>() { name });
                }

            }

            foreach (var course in studentsByCourses.OrderByDescending(v => v.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}
