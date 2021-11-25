using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroAndMana = new Dictionary<string, int>();
            Dictionary<string, int> heroAndHIT = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = input[0];
                int hitPoint = int.Parse(input[1]);
                int manaPoint = int.Parse(input[2]);

                if (!heroAndHIT.ContainsKey(heroName))
                {
                    heroAndMana.Add(heroName, manaPoint);
                    heroAndHIT.Add(heroName, hitPoint);
                }


            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] command = inputCommand
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);


                if (command[0].Equals("CastSpell"))
                {
                    string heroName = command[1];
                    int manaNeeded = int.Parse(command[2]);
                    string spellName = command[3];

                    bool checker = heroAndMana[heroName] >= manaNeeded;

                    if (heroAndMana[heroName] - manaNeeded >= 0)
                    {
                        heroAndMana[heroName] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroAndMana[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }


                else if (command[0].Equals("TakeDamage"))
                {
                    string heroName = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    heroAndHIT[heroName] -= damage;

                    if (heroAndHIT[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroAndHIT[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroAndMana.Remove(heroName);
                        heroAndHIT.Remove(heroName);
                    }

                }


                else if (command[0].Equals("Recharge"))
                {
                    string heroName = command[1];
                    int ammount = int.Parse(command[2]);

                    if (heroAndMana[heroName] + ammount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - heroAndMana[heroName]} MP!");
                        heroAndMana[heroName] = 200;

                    }
                    else
                    {
                        heroAndMana[heroName] += ammount;
                        Console.WriteLine($"{heroName} recharged for {ammount} MP!");
                    }
                }


                else if (command[0].Equals("Heal"))
                {
                    string heroName = command[1];
                    int ammount = int.Parse(command[2]);

                    if (heroAndHIT[heroName] + ammount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroAndHIT[heroName]} HP!");
                        heroAndHIT[heroName] = 100;

                    }
                    else
                    {
                        heroAndHIT[heroName] += ammount;
                        Console.WriteLine($"{heroName} healed for {ammount} HP!");
                    }

                }


                inputCommand = Console.ReadLine();
            }

            foreach (var hero in heroAndHIT.OrderByDescending(n => n.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroAndMana[hero.Key]}");
            }
        }
    }
}
