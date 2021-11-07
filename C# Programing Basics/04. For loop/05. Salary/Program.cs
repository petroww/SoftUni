using System;
using System.Runtime.InteropServices.ComTypes;

namespace facebookTabGlobi
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());

            int salary = int.Parse(Console.ReadLine());

            int lostMoney = 0;

            string pages;
            for (int i = 0; i < tabs; i++)
            {
                pages = Console.ReadLine();

                if (pages == "Facebook")
                {
                    lostMoney += 150;
                }
                else if (pages == "Instagram")
                {
                    lostMoney += 100;
                }
                else if (pages == "Reddit")
                {
                    lostMoney += 50;
                }

                if (lostMoney >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;

                }


            }
            if (salary > lostMoney)
            {
                Console.WriteLine(salary - lostMoney);
            }


        }
    }
}
