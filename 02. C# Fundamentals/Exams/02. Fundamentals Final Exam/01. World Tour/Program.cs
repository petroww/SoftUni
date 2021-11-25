using System;
using System.Text;
using System.Text.RegularExpressions;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string tour = Console.ReadLine();


            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] command = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string str = command[2];

                    bool checker = index >= 0 && index < tour.Length;

                    if (checker)
                    {
                        tour = tour.Insert(index, str).ToString();
                    }
                    Console.WriteLine(tour);
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    bool isValid = (startIndex >= 0 && startIndex < tour.Length) && (endIndex >= 0 && endIndex < tour.Length);
                    if (isValid)
                    {
                        tour = tour.Remove(startIndex, endIndex - startIndex + 1).ToString();
                    }
                    Console.WriteLine(tour);

                }
                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];


                    while (tour.Contains(oldString))
                    {

                        tour = tour.Replace(oldString, newString).ToString();

                    }
                    Console.WriteLine(tour);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {tour}");
        }
    }
}
