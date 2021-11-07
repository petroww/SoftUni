using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumVacation = double.Parse(Console.ReadLine());
            double moneyJesie = double.Parse(Console.ReadLine());

            int days = 1;
            int daysSpend = 0;

            while (moneyJesie < sumVacation)
            {
                string action = Console.ReadLine();
                double sumSpentSaved = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    moneyJesie = moneyJesie + sumSpentSaved;
                    daysSpend = 0;

                }
                else if (action == "spend")
                {
                    if (sumSpentSaved > moneyJesie)
                    {
                        moneyJesie = 0;

                    }
                    else
                    {
                        moneyJesie -= sumSpentSaved;

                    }
                    daysSpend++;

                }

                if (daysSpend == 5 && action == "spend")
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                if (moneyJesie >= sumVacation)
                {
                    Console.WriteLine($"You saved the money for {days} days.");

                    break;
                }

                days++;
            }

        }
    }
}