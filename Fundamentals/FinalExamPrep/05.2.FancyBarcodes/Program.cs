using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _05._2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match validBarCode = regex.Match(input);

                string digitpattern = @"\d";
                Regex digitRegex = new Regex(digitpattern);

                if (validBarCode.Success)
                {
                    var matchedGroup = digitRegex.Matches(validBarCode.ToString());

                    if (matchedGroup.Count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", matchedGroup)}");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

            
            
        }
    }
}
