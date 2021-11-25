using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    ;


                if (command[0].Equals("TakeOdd"))
                {
                    int i = 0;
                    while (i < password.Length)
                    {
                        password = password.Remove(i, 1);
                        i++;
                    }
                    Console.WriteLine(password);
                }
                else if (command[0].Equals("Cut"))
                {
                    int index = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);

                    password = password.Remove(index, lenght);

                    Console.WriteLine(password);
                }
                else if (command[0] == "Substitute")
                {
                    string substring = command[1];
                    string substitute = command[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                        Console.WriteLine("Nothing to replace!");
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
