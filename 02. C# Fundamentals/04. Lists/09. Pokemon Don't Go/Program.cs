using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int sumRemoveDigits = 0;


            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstElement = numbers[0];
                    sumRemoveDigits += firstElement;
                    numbers[0] = numbers[numbers.Count - 1];
                    for (int j = 0; j < numbers.Count; j++)
                    {

                        if (firstElement >= numbers[j])
                        {
                            numbers[j] += firstElement;
                        }
                        else
                        {
                            numbers[j] -= firstElement;
                        }

                    }

                }
                else if (index >= numbers.Count)
                {
                    int lastElement = numbers[numbers.Count - 1];
                    sumRemoveDigits += lastElement;
                    numbers[numbers.Count - 1] = numbers[0];
                    for (int j = 0; j < numbers.Count; j++)
                    {

                        if (lastElement >= numbers[j])
                        {
                            numbers[j] += lastElement;
                        }
                        else
                        {
                            numbers[j] -= lastElement;
                        }

                    }
                }
                else
                {
                    int remove = numbers[index];
                    sumRemoveDigits += remove;
                    numbers.RemoveAt(index);
                    for (int j = 0; j < numbers.Count; j++)
                    {

                        if (remove >= numbers[j])
                        {
                            numbers[j] += remove;
                        }
                        else
                        {
                            numbers[j] -= remove;
                        }

                    }

                }
            }
            Console.WriteLine(sumRemoveDigits);
        }
    }
}
