using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Generate")
                {
                    break;
                }
                string[] split = command.Split(">>>");
                if (split[0] == "Contains")
                {
                    string substring = split[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}“");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (split[0] == "Flip")
                {
                    if (split[1] == "Upper")
                    {
                        int startIndex = int.Parse(split[2]);
                        int endIndex = int.Parse(split[3]);

                        int lenght = endIndex - startIndex;
                        string substring = key.Substring(startIndex, lenght);

                        key = key.Replace(substring, substring.ToUpper());

                        Console.WriteLine(key);

                    }
                    else if (split[1] == "Lower")
                    {
                        int startIndex = int.Parse(split[2]);
                        int endIndex = int.Parse(split[3]);

                        int lenght = endIndex - startIndex;

                        string substring = key.Substring(startIndex, lenght);

                        key = key.Replace(substring, substring.ToLower());


                        Console.WriteLine(key);


                    }
                }
                else if (split[0] == "Slice")
                {
                    int startIndex = int.Parse(split[1]);
                    int endIndex = int.Parse(split[2]);
                    int lenght = endIndex - startIndex;
                    key = key.Remove(startIndex, lenght);
                    Console.WriteLine(key);
                }

            }

            Console.WriteLine($"Your activation key is: {key}");

        }
    }
}