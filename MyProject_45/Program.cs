using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  =========================
 *  #_FUNCTIONS AND METHODS_#
 *  =========================
 *  HOMEWORK #6_01:
 *  #SimpleCode Solution
 *  
 *      - To write the method, which print string on display. Symbols or text in the string and their number of copies is entered by the user;
 */

namespace MyProject_45
{
    class Program
    {
        static void PrintLine (string symbolText, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbolText + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your text/symbol: ");
            string randomText = Console.ReadLine();

            Console.Write("Enter number of copies: ");
            uint copyCount = uint.Parse(Console.ReadLine());

            PrintLine(randomText, copyCount);

            Console.WriteLine();
        }
    }
}
