using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 *    #SimpleCode_Calculator
 *    
 *    HOMEWORK #3: 
 *    To make a calculator in 2 ways with help of statements IF-ELSE-IF and SWITCH statements.
 *    
 *    Variant II. IF-ELSE-IF statement
 *    
 */

namespace MyProject_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                string action;

                Console.WriteLine("Welcome to #SimpleCode_Calculator!");

                try
                {
                    Console.WriteLine("Enter your first value:");
                     firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your second value:");
                     secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!!!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Please, choose numerical action you need to: +, -, *, /");
                 action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine("Your result is: " + Math.Round(firstValue + secondValue, 2));
                }
                else if (action == "-")
                {
                    Console.WriteLine("Your result is: " + Math.Round(firstValue - secondValue, 2));
                }
                else if (action == "*")
                {
                    Console.WriteLine("Your result is: " + Math.Round(firstValue * secondValue, 2));
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("Your result is: " + Math.Round(firstValue / secondValue, 2));
                }
                else
                {
                    Console.WriteLine("You choose the wrong type of operator!!");
                }

                Console.WriteLine("Thank you for using our calculator!");
                Console.ReadLine();
            }
        }
    }
}
