using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  MATH Class Division Example
 * 
 *  How to decrease a number of digits after decimal point 
 * 
 *  Math.Round(value, 2);
 *  
 *  where,
 *      value - inputted expression or value;
 *      2 - is number of digits after decimal point;
 *      
 */

namespace MyProject_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue = double.Parse(Console.ReadLine());
                double secondValue = double.Parse(Console.ReadLine());

                double result = firstValue / secondValue;

                Console.WriteLine(Math.Round(result, 2));

                Console.ReadLine();
            }
        }
    }
}
