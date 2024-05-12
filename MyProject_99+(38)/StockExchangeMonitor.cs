using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyProject_137
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler {  get; set; }
        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = (new Random()).Next(50);
                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }
    }
}
