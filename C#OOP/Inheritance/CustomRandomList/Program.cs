using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randm = new RandomList { "1", "2", "3", "4" };

            Console.WriteLine(randm.RandomString()); 
            

            foreach (var item in randm)
            {
                Console.WriteLine(item);
            }
        }
    }
}
