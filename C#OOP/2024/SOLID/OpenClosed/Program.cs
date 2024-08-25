using OpenClosed.Contracts;
using OpenClosed.Contracts.Strategies;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISortingStrategy sortingStrategy = null;

            Console.WriteLine("Your sorting strategy is:");

            try
            {
                string strategyName = Console.ReadLine();

                switch (strategyName.ToLower())
                {
                    case "selection":
                        sortingStrategy = new SelectionSort();
                        break;
                    case "bubble":
                        sortingStrategy = new BubbleSort();
                        break;
                    case "quick":
                        sortingStrategy = new QuickSort();
                        break;
                    default:
                        throw new Exception("Please check your sorting strategy name !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
   
            Sorter sorter = new Sorter(sortingStrategy);
            sorter.Sort(new List<int>());
        }
    }
}
