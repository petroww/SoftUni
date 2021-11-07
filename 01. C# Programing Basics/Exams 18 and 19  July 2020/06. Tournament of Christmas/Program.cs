using System;

namespace ChristmasTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfDays = int.Parse(Console.ReadLine());
            var NameOfGame = "";
            var WinOrLose = "";



            double TotalPrice = 0;
            int TotalWinGames = 0;
            int TotalLoseGames = 0;


            double PriceWin = 0;
            int CounterForWin = 0;
            int counterForLose = 0;

            for (int i = 1; i <= NumberOfDays; i++)
            {
                while (true)
                {
                    NameOfGame = Console.ReadLine();
                    if (NameOfGame == "Finish")
                    {
                        if (CounterForWin > counterForLose)
                        {
                            PriceWin = PriceWin + (PriceWin * 0.1);
                        }
                        TotalPrice += PriceWin;
                        PriceWin = 0;

                        TotalWinGames += CounterForWin;
                        CounterForWin = 0;

                        TotalLoseGames += counterForLose;
                        counterForLose = 0;

                        break;
                    }
                    else
                    {
                        WinOrLose = Console.ReadLine();
                        if (WinOrLose == "win")
                        {
                            CounterForWin++;
                            PriceWin += 20;


                        }
                        else if (WinOrLose == "lose")
                        {
                            counterForLose++;
                            PriceWin += 0;
                        }

                    }

                }


            }
            if (TotalWinGames > TotalLoseGames)
            {
                TotalPrice = TotalPrice + TotalPrice * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {TotalPrice:F2}");
            }
            else
                Console.WriteLine($"You lost the tournament! Total raised money: {TotalPrice:F2}");
        }
    }
}
