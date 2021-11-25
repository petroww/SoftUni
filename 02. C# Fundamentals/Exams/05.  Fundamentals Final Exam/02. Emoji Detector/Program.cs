using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emogi_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex validEmoji = new Regex(@"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1");

            MatchCollection emojies = validEmoji.Matches(text);

            int countValidEmoji = emojies.Count;

            Dictionary<string, int> emojiSuming = new Dictionary<string, int>();

            foreach (Match item in emojies)
            {
                //проверка дали емоджито се съдържа в речника
                string allEmoji = item.Value;
                if (!emojiSuming.ContainsKey(allEmoji))
                {
                    emojiSuming.Add(allEmoji, 0);
                }

                //сумиране на аски символите на емоджито
                string nameEmoji = item.Groups["emoji"].Value;
                int sumEmo = 0;
                for (int i = 0; i < nameEmoji.Length; i++)
                {
                    sumEmo += Convert.ToInt32(nameEmoji[i]);
                }
                //добавяне на сумата на аски символите към ключа
                emojiSuming[allEmoji] = sumEmo;


            }

            int multiplingThreshold = 1;
            string thresholdSTR = "";
            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsDigit(text[i]))
                {
                    thresholdSTR += text[i];
                }

            }
            for (int i = 0; i < thresholdSTR.Length; i++)
            {
                int num = thresholdSTR[i] - '0';
                multiplingThreshold *= num;
            }
            List<string> theCoolOneEmoji = new List<string>();

            foreach (var item in emojiSuming)
            {
                if (item.Value > multiplingThreshold)
                {
                    theCoolOneEmoji.Add(item.Key);
                }
            }

            Console.WriteLine($"Cool threshold: {multiplingThreshold}");
            Console.WriteLine($"{countValidEmoji} emojis found in the text. The cool ones are:");
            foreach (var item in theCoolOneEmoji)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
