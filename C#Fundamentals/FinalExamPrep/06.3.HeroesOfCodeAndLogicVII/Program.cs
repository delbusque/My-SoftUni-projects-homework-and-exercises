using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _06._3.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] insertHeroes = Console.ReadLine().Split();
                heroes.Add(insertHeroes[0], new List<int>());
                heroes[insertHeroes[0]].Add(int.Parse(insertHeroes[1])); 
                heroes[insertHeroes[0]].Add(int.Parse(insertHeroes[2]));
            }   

            string[] cmdArgs = Console.ReadLine().Split(" - ");

            while (cmdArgs[0] != "End")
            {
                string command = cmdArgs[0];
                string heroName = cmdArgs[1];

                int heroHP = heroes[heroName][0];
                int heroMP = heroes[heroName][1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroMP >= mpNeeded)
                        {
                            heroes[heroName][1] -= mpNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                    }
                }

                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroes[heroName][0] -= damage;

                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }

                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    heroes[heroName][1] += amount;

                    if (heroes[heroName][1] > 200)
                    {
                        int rechargedFor = amount - (heroes[heroName][1] - 200);
                        Console.WriteLine($"{heroName} recharged for {rechargedFor} MP!");
                      
                        heroes[heroName][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    
                }

                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    heroes[heroName][0] += amount;

                    if (heroes[heroName][0] > 100)
                    {
                        int healedFor = amount - (heroes[heroName][0] - 100);

                        Console.WriteLine($"{heroName} healed for {healedFor} HP!");
                        heroes[heroName][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }

                    
                }

                cmdArgs = Console.ReadLine().Split(" - ");
            }

            foreach (var item in heroes.OrderByDescending(h=>h.Value[0]).ThenBy(h=>h.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }

        }
    }
}
