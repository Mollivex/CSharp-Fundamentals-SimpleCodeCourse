using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq.Expressions;

/*
 * Finding the average number
 * 
 * HOMEWORK #2:
 * To find the average of 2 values entered into console
 * 
 */

namespace MyProject_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Input first value:");
            firstValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input second value:");
            secondValue= Double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Your average number: " + result);

            Console.ReadLine();

        }
    }
}
