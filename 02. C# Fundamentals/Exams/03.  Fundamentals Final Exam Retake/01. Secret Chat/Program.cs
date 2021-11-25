using System;
using System.Text;

namespace _1_Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();




            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] command = input.Split(":|:");

                if (command[0] == "InsertSpace")
                {
                    int index = Convert.ToInt32(command[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }


                else if (command[0] == "Reverse")
                {
                    string substring = command[1];

                    if (message.Contains(substring))
                    {
                        int indexStart = message.IndexOf(substring);

                        string reversed = "";

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }
                        message = message.Remove(indexStart, substring.Length);
                        message += reversed;
                    }
                    else
                        Console.WriteLine("error");
                    Console.WriteLine(message);

                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];


                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
