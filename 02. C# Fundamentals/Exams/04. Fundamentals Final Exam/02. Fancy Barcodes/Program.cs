using System;
using System.Text.RegularExpressions;

namespace practic_gefore_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex barcodePartition = new Regex(@"(\@\#{1,})(?<product>[A-Z][a-zA-Z0-9]{4,}[A-Z])@#+");
            Regex digitsInBarcodePartition = new Regex(@"\d");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputBarcod = Console.ReadLine();
                Match validbarcode = barcodePartition.Match(inputBarcod);
                string digits = "";

                if (validbarcode.Success)
                {
                    string product = validbarcode.Groups["product"].Value;

                    MatchCollection digitsbarcode = digitsInBarcodePartition.Matches(product);

                    foreach (Match item in digitsbarcode)
                    {
                        if (item.Success)
                        {
                            digits += item.Value;
                        }

                    }
                    if (digits == string.Empty)
                    {
                        digits = "00";
                    }

                    Console.WriteLine($"Product group: {digits}");



                }
                else
                {

                    Console.WriteLine("Invalid barcode");

                }

            }
        }
    }
}
