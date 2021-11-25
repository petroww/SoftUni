using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_For_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();


            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = Convert.ToInt32(input[2]);

                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new List<int>() { 0, 0 });
                    cars[car][0] = mileage;
                    cars[car][1] = fuel;

                }
            }

            string inputCommands = Console.ReadLine();
            while (inputCommands != "Stop")
            {
                string[] command = inputCommands.Split(" : ");

                if (command[0] == "Drive")
                {
                    string car = command[1];
                    int distance = Convert.ToInt32(command[2]);
                    int needfuel = int.Parse(command[3]);

                    if (cars[car][1] < needfuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= needfuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {needfuel} liters of fuel consumed.");
                        if (cars[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }

                }

                else if (command[0] == "Refuel")
                {
                    string car = command[1];
                    int fuel = int.Parse(command[2]);

                    if (cars[car][1] + fuel > 75)
                    {
                        int takenFuel = 75 - cars[car][1];
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {takenFuel} liters");
                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");

                    }
                }

                else if (command[0] == "Revert")
                {
                    string car = command[1];
                    int kilometers = int.Parse(command[2]);

                    cars[car][0] -= kilometers;

                    if (cars[car][0] < 10000)
                    {
                        cars[car][0] = 10000;

                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                inputCommands = Console.ReadLine();
            }


            foreach (var car in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
