using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            int sum = 0;

            while (pokemons.Count > 0)
            {                                                           
                int index = int.Parse(input);

                if (index <= pokemons.Count-1 && index >= 0)
                {
                    if (index >= 0)
                    {
                        for (int i = 0; i < pokemons.Count - 1; i++)
                        {
                            if (pokemons[i] <= pokemons[index])
                            {
                                pokemons[i] += pokemons[index];
                            }
                            else
                            {
                                pokemons[i] -= pokemons[index];
                            }
                        }

                        sum += pokemons[index];
                        pokemons.RemoveAt(index);
                    }
                    else
                    {
                        sum += pokemons[0];
                        pokemons.RemoveAt(0);
                        pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    }
                }

                else if (index > pokemons.Count-1)
                {
                    sum += pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons[pokemons.Count - 1]);
                    pokemons.Insert(pokemons[pokemons.Count], pokemons[0]);
                }

                if (pokemons.Count > 0)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine(sum);

        }
    }
}
