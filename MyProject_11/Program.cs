using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *    #SimpleCode_Calculator
 *    
 *    HOMEWORK #3: 
 *    To make a calculator in 2 ways with help of statements IF-ELSE-IF and SWITCH statements.
 *    
 *    Variant I. SWITCH statement
 */

namespace MyProject_11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                string result;

                Console.WriteLine("Welcome to #SimpleCode_Calculator!");
                
                try 
                {
                    Console.WriteLine("Enter your first value:");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your second value:");
                    secondValue = double.Parse(Console.ReadLine());
                } 
                catch(Exception)
                {
                    Console.WriteLine("Input error!!!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Please enter two values and choose numerical action: +, -, /, *");
                 result = Console.ReadLine();

                switch (result)
                {
                    case "+":
                        Console.WriteLine("Sum Operation is succesfully completed!");
                        Console.WriteLine("Result is " + Math.Round(firstValue + secondValue, 2));
                        break;

                    case "-":
                        Console.WriteLine("Substract Operation is succesfully completed!");
                        Console.WriteLine("Result is " + Math.Round(firstValue - secondValue, 2));
                        break;

                    case "/":

                        if (secondValue == 0) 
                            Console.WriteLine(0);
                        else
                            Console.WriteLine("Division Operation is succesfully completed!");
                            Console.WriteLine("Result is " + Math.Round(firstValue / secondValue, 2));
                        break;

                    case "*":
                        Console.WriteLine("Multiplication Operation is succesfully completed!");
                        Console.WriteLine("Result is " + Math.Round(firstValue * secondValue, 2));
                        break;

                    default:
                        {
                            Console.WriteLine("You choose wrong numerical action!");
                        }
                        break;
                }
                Console.WriteLine("\nThank you for using our calculator!!");
                Console.ReadLine();
            }
        }
    }
}
