using System;

namespace Operation_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();

            double operation = 0;
            string typeOfNum = "";
            if (Operator == "+")
                operation = N1 + N2;
            else if (Operator == "-")
                operation = N1 - N2;
            else if (Operator == "*")
                operation = N1 * N2;
            else if (Operator == "/")
                operation = N1 / N2;
            else if (Operator == "%")
                operation = N1 % N2;

            if (Operator == "%")
            {
                if (N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N2} by zero");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");

                }
                else
                    Console.WriteLine($"{N1} {Operator} {N2} = {operation}");
            }



            else if (Operator == "/")
            {
                if (N1 == 0)
                    Console.WriteLine($"Cannot divide {N2} by zero");
                else if (N2 == 0)
                    Console.WriteLine($"Cannot divide {N1} by zero");
                else
                    Console.WriteLine($"{N1} {Operator} {N2} = {operation:F2}");
            }

            else if (Operator == "-" || Operator == "+" || Operator == "*")
            {
                if (operation % 2 == 0)
                    typeOfNum = "even";
                else
                    typeOfNum = "odd";

                Console.WriteLine($"{N1} {Operator} {N2} = {operation} - {typeOfNum}");
            }





        }
    }
}
