using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()); 
            Queue<int> threads = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int taskToKill = int.Parse(Console.ReadLine());
            bool isKilled = false;
            int threadKilledTheTask = 0;

            while (true)
            {
                if (isKilled)
                {
                    break;
                }

                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentThread >= currentTask)
                {  
                    if (currentTask == taskToKill)
                    {
                        threads.Dequeue();
                        tasks.Pop();
                        Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");                       
                        
                        threadKilledTheTask = currentThread;
                        isKilled = true;
                    }
                    else
                    {
                        threads.Dequeue();
                        tasks.Pop();
                    }
                }

                else
                {
                    if (currentTask == taskToKill)
                    {
                        threads.Dequeue();
                        Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");

                        threadKilledTheTask = currentThread;
                        isKilled = true;
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }
                List<int> result = new List<int>(threads);
                result.Insert(0, threadKilledTheTask);
                Console.WriteLine(string.Join(" ", result));                     
        }
    }
}
