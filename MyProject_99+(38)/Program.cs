using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================
 * Delegates in C# | Example of using
 * ==================================
 * 
 */

namespace MyProject_137
{
    class Program
    {
        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");
        }
        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;
            stockExchangeMonitor.Start();
        }
    }
}
