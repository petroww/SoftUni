using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsCollection = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] students = line
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = students[0];
                string lastName = students[1];
                int age = int.Parse(students[2]);
                string homeTown = students[3];


                Student student = new Student()
                {
                    Age = age,
                    FirstName = firstName,
                    HomeTown = homeTown,
                    LastName = lastName,
                };
                studentsCollection.Add(student);
            }

            string townName = Console.ReadLine();

            foreach (Student student in studentsCollection)
            {
                if (student.HomeTown == townName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }


        }
    }
}


