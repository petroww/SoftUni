using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "course start")
                {
                    break;
                }

                string[] command = line
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstCommand = command[0];
                string lessonTitle = command[1];

                switch (firstCommand)
                {
                    case "Add":
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Add(lessonTitle);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":
                        if (lessons.Contains(lessonTitle))
                        {
                            lessons.Remove(lessonTitle);
                        }
                        else if (lessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            lessonTitle.Remove(lessons.IndexOf($"{lessonTitle}-Exercise"));
                        }
                        break;

                    case "Swap":
                        string firstLessonTitle = lessonTitle;
                        string secondLessonTitle = command[2];
                        if (lessons.Contains(firstLessonTitle) && lessons.Contains(secondLessonTitle) 
                            || lessons.Contains($"{lessonTitle}-Exercise") && lessons.Contains(secondLessonTitle) 
                            || lessons.Contains($"{lessonTitle}-Exercise") && lessons.Contains(firstLessonTitle))
                        {
                            for (int i = 0; i < lessons.Count; i++)
                            {
                                if (lessons[i] == firstLessonTitle)
                                {
                                    lessons[i] = secondLessonTitle;
                                }
                                else if (lessons[i] == secondLessonTitle)
                                {
                                    lessons[i] = firstLessonTitle;
                                }
                            }
                        }
                        
                        break;

                    case "Exercise":
                        if (!lessons.Contains(lessonTitle))
                        {
                            lessons.Add(lessonTitle);
                            lessons.Insert(lessons.IndexOf(lessonTitle) - 1 ,$"{lessonTitle}-Exercise");
                        }
                        else if (lessons.Contains(lessonTitle) && !lessons.Contains($"{lessonTitle}-Exercise"))
                        {
                            lessons.Insert(lessons.IndexOf(lessonTitle) - 1, $"{lessonTitle}-Exercise");
                        }
                        break;
                }
            }
            Console.WriteLine();

            int lessonsNumber = 0;
            foreach (string element in lessons)
            {
                lessonsNumber++;
                Console.WriteLine($"{lessonsNumber}.{element}");
            }

        }
    }
}
