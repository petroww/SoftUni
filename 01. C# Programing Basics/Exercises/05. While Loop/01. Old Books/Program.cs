using System;
using System.Diagnostics.Tracing;

namespace Starata_Bilbioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            string Book = Console.ReadLine();

            string LookingForBook = " ";
            int counter = 0;

            while ((LookingForBook = Console.ReadLine()) != "No More Books")
            {

                if (LookingForBook == Book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");

                    break;
                }
                counter++;
            }
            if (LookingForBook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked { counter} books.");
            }
        }
    }
}
