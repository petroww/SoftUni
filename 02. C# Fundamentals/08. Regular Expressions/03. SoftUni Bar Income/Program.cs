using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end of shift")
                {
                    break;
                }
                string patern = @"";
                Regex regex = new Regex(patern);
                var matches = regex.Matches(text);
                ;
            }
        }
    }
}
