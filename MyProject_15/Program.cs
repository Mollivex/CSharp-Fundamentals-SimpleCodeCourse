using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * 
 *  Number of EVEN and ODD values in range
 *  
 *  HOMEWORK #2:
 *  
 *  To find a number of EVEN and ODD values in the range, entered by user.
 * 
 */

namespace MyProject_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counters of variables
            uint oddNumbersCount = 0; // ODD numbers
            uint evenNumbersCount = 0; // EVEN numbers

            // Counters of sum of elements
            int oddNumbersSum = 0; // ODD numbers SUM
            int evenNumbersSum = 0; // EVEN numbers SUM

            Console.WriteLine("Welcome to #SimpleCode_ODD/EVEN range calculator!");

            Console.WriteLine("Please, enter beginning of the range:");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter limit of the range:");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue; // VARIANT 1 of syntax (a = a + b)
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum = oddNumbersSum + currentValue; // VARIANT 2 of syntax (a+=b)
                }
                currentValue++;
            }

            Console.WriteLine("Number of Odd values: " + oddNumbersCount);
            Console.WriteLine("Number of Even values: " + evenNumbersCount);

            Console.WriteLine("Sum of Odd numbers range:" + oddNumbersSum);
            Console.WriteLine("Sum of Even numbers range:" + evenNumbersSum);

            Console.WriteLine("Thank you for using our calctulator!");

            Console.ReadLine();

        }
    }
}
