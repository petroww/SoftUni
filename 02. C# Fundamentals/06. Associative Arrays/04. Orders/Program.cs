using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> quantityByProduct = new Dictionary<string, double>(); 

            Dictionary<string, double> priceByProduct = new Dictionary<string, double>();

            

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "buy")
                {
                    break;
                }
                string[] productWithPriceAndQuantity = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string product = productWithPriceAndQuantity[0];
                double pricePerProduct = double.Parse(productWithPriceAndQuantity[1]);
                int quantityPerProduct = int.Parse(productWithPriceAndQuantity[2]);

                if (!quantityByProduct.ContainsKey(product))
                {
                    quantityByProduct.Add(product,quantityPerProduct);
                    priceByProduct.Add(product,pricePerProduct);
                }
                else
                {
                    quantityByProduct[product] += quantityPerProduct;
                    priceByProduct[product] = pricePerProduct;
                }
            }

            foreach (var element in priceByProduct)
            {
                string elements = element.Key;
                double price = element.Value;
                int qauntity = (int)quantityByProduct[elements];

                double totalPrice = qauntity * price;
                Console.WriteLine($"{elements} -> {totalPrice:F2}");
            }
        }
    }
}
