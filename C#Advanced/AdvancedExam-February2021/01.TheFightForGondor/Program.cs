using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Stack<int> remainningOrcs = new Stack<int>();

            for (int i = 1; i < waves + 1; i++)
            {
                Stack<int> orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                while (plates.Count > 0 && orcs.Count > 0)
                {

                    if (i % 3 == 0)
                    {
                        int extraPlate = int.Parse(Console.ReadLine());
                        plates.Enqueue(extraPlate);
                    }

                    if (orcs.Peek() > plates.Peek())
                    {
                        while (orcs.Peek() > 0)
                        {
                            int value = plates.Dequeue();
                            int newValue = orcs.Pop() - value;
                            orcs.Push(newValue);

                            if (orcs.Peek() > plates.Peek())
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    else if (plates.Peek() > orcs.Peek())
                    {
                        int value = orcs.Pop();
                        int newValue = plates.Peek() - value;
                        plates.Enqueue(newValue);
                    }

                    else
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }
                }

                remainningOrcs = orcs;
            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (plates.Count == 0)
            {
                StringBuilder sb = new StringBuilder();
                
                foreach (var orc in remainningOrcs)
                {
                    sb.Append($"{orc}, ");
                }

                string left = sb.ToString();
                char[] toTrim = new[] { ',', ' ' };
                left = left.TrimEnd(toTrim);
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (var plate in plates)
                {
                    sb.Append($"{plate}, ");
                }

                string left = sb.ToString();
                char[] toTrim = new[] { ',', ' ' };
                left = left.TrimEnd(toTrim);
            }

            
        }
    }
}
