using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string inputComand = Console.ReadLine();
            while (inputComand != "end")
            {
                string[] str = inputComand.Split();

                if (str[0] == "swap")
                {
                    int first = int.Parse(str[1]);
                    int second = int.Parse(str[2]);
                    int helper = array[first];

                    array[first] = array[second];

                    array[second] = helper;

                }
                else if (str[0] == "multiply")
                {
                    int first = int.Parse(str[1]);
                    int second = int.Parse(str[2]);

                    array[first] = array[first] * array[second];
                }
                else if (str[0] == "decrease")
                {
                    for (int i = 0; i < array.Count; i++)
                    {

                        array[i] = array[i] + (-1);


                    }
                }
                if (str[0] == "show")
                {
                    Console.WriteLine(string.Join(" ", array));
                }
                inputComand = Console.ReadLine();

            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
