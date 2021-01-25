using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {
                switch (input[1])
                {
                    case "joined":

                        Vlogger newVloger = new Vlogger(input[0]);
                        vloggers.Add(newVloger);
                        break;

                    case "followed":
                        string following = input[0];
                        string followed = input[2];

                        Vlogger vlogger1 = (Vlogger)vloggers.Where(vl => vl.Name == following);
                        
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }

    public class Vlogger
    {
        public string Name { get; set; }
        public HashSet<string> Following { get; set; }
        public SortedSet<string> Followed { get; set; }

        public Vlogger(string name)
        {
            this.Name = name;
            this.Following = new HashSet<string>();
            this.Followed = new SortedSet<string>();
        }
    }
}
