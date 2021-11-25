using System;

namespace The_imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string cript = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Move")
                {
                    int numberOfLetter = int.Parse(command[1]);
                    string letter = "";
                    for (int i = 0; i < numberOfLetter; i++)
                    {
                        letter += cript[i];
                    }
                    cript = cript.Remove(0, numberOfLetter);
                    cript = cript + letter;

                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    cript = cript.Insert(index, value);
                }
                else if (command[0] == "ChangeAll")
                {
                    char substring = char.Parse(command[1]);
                    char replacement = Convert.ToChar(command[2]);


                    cript = cript.Replace(substring, replacement);


                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {cript}");
        }
    }
}
