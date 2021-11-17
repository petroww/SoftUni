using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> employeByCompany = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] cmArgs = line
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = cmArgs[0];
                string idNumber = cmArgs[1];

                if (employeByCompany.ContainsKey(company))
                {
                    if (!employeByCompany[company].Contains(idNumber))
                    {
                        employeByCompany[company].Add(idNumber);
                    }
                }

                else
                {
                    employeByCompany.Add(company, new List<string>() { idNumber });
                }
            }
            string saveElement = string.Empty;
            foreach (var cvp in employeByCompany)
            {
                Console.WriteLine($"{cvp.Key}");
                foreach (var id in cvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }

            }

        }
    }
}
