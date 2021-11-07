using System;

namespace Trekking_Maniq
{
    class Program
    {
        static void Main(string[] args)
        {
            int Groups = int.Parse(Console.ReadLine());


            double Musala = 0;
            double Monblan = 0;
            double Kilimandzaro = 0;
            double K2 = 0;
            double Everest = 0;

            double AllPeople = 0;

            for (int i = 1; i <= Groups; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                AllPeople += countPeople;
                if (countPeople <= 5)
                {
                    Musala += countPeople;
                }
                else if (countPeople >= 6 && countPeople <= 12)
                {
                    Monblan += countPeople;
                }
                else if (countPeople >= 13 && countPeople <= 25)
                {
                    Kilimandzaro += countPeople;
                }
                else if (countPeople >= 26 && countPeople <= 40)
                {
                    K2 += countPeople;
                }
                else if (countPeople >= 41)
                {
                    Everest += countPeople;
                }

            }

            double percentForMusala = Musala / AllPeople * 100;
            double percentForMonblan = Monblan / AllPeople * 100;
            double percentForKilimandzaro = Kilimandzaro / AllPeople * 100;
            double percentForK2 = K2 / AllPeople * 100;
            double percentForEverest = Everest / AllPeople * 100;

            Console.WriteLine("{0:F2}%", percentForMusala);
            Console.WriteLine("{0:F2}%", percentForMonblan);
            Console.WriteLine("{0:F2}%", percentForKilimandzaro);
            Console.WriteLine("{0:F2}%", percentForK2);
            Console.WriteLine("{0:F2}%", percentForEverest);
        }
    }
}
