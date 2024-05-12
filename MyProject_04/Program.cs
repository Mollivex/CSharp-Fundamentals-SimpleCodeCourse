using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * Sum & Multiplication 
 * 
 * HOMEWORK #1
 * To make a SUM and MULTIPLICATION operations with a 3 numbers;
 * 
 */

namespace MyProject_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Input your first value:");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Input your second value:");
            secondValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Input your third value:");
            thirdValue= double.Parse(Console.ReadLine());

            double sumResult = firstValue+ secondValue + thirdValue;
            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Your SUM result: " + sumResult);
            Console.WriteLine("Your MULT result: " + multResult);
        }
    }
}
