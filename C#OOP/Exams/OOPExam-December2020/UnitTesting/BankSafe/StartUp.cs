using System;

namespace BankSafe
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Item item = new Item("Peter", "123X");

            Console.WriteLine(item.Owner);

            BankVault vault = new BankVault();

            foreach (var cell in vault.VaultCells)
            {
                
                Console.WriteLine($"{cell.Key} - {cell.Value}");
            }
        }
    }
}
