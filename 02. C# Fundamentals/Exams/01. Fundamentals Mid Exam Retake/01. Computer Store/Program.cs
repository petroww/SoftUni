using System;
using System.Linq;

namespace Mid_Exam_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumWithouthTaxes = 0;
            double taxes = 0;
            double totalPrice = 0;
            int count = 0;

            bool flag = true;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special")
                {

                    taxes = sumWithouthTaxes * 0.2;
                    totalPrice = totalPrice + taxes + sumWithouthTaxes;
                    double discount = totalPrice * 0.1;
                    totalPrice -= discount;
                    break;

                }
                else if (input == "regular")
                {
                    taxes = sumWithouthTaxes * 0.2;
                    totalPrice = totalPrice + taxes + sumWithouthTaxes;
                    break;
                }

                double convert = double.Parse(input);


                if (convert < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                sumWithouthTaxes += convert;



            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");

            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sumWithouthTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");

            }

        }
    }
}
