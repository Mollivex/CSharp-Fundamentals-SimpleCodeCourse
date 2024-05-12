using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================
 * Recursion in C# | HOMEWORK #8_03
 * ================================
 * 
 *  -!- Create an application which finds the number digits SUM with a recursive methods.
 * 
 */

namespace MyProject_65
{
    class Program
    {
        /// <summary>
        /// Sum number of digits (option_#1)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static int Foo(int value)
        {
            if (value < 10) 
                return value;
            int digit = value % 10;

            int nextValue = value / 10;

            return digit + Foo(nextValue);
        }

        /// <summary>
        /// Sum number of digits (option_#2)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static int Bar (int value)
        {
            if (value < 10)
                return value;

            return value % 10 + Bar(value / 10);
        }

        /// <summary>
        /// Sum number of digits (option_#3)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static int SumLoop(int value, int result = 0)
        {
            while (value > 0)
            {
                result += value % 10;
                value /= 10;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your number to sum digits: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSum of digits (Option_#1): " + Foo(i));

            Console.WriteLine("\nSum of digits (Option_#2): " + Bar(i));

            Console.WriteLine("\nSum of digits (Option_#3): " + SumLoop(i));

            Console.ReadLine();
        }
    }
}
