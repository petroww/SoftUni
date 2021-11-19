using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0.0;
            foreach (var item in words)
            {    //A12b
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                
                string digitSubString = item.Substring(1, item.Length - 2);
                double digit = double.Parse(digitSubString);



                if (firstLetter == char.ToUpper(firstLetter))
                {
                    digit /= firstLetter - 64;
                }
                else
                {
                    digit *= firstLetter - 96;
                }

                if (lastLetter == char.ToUpper(lastLetter))
                {
                    digit -= lastLetter - 64;
                }
                else
                {
                    digit += lastLetter - 96;
                }
                result += digit;

            }
            Console.WriteLine($"{result:F2}");
            ;
        }
    }
}
