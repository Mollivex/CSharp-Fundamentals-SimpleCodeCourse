using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========
 * for Loop 
 * =========
 * 
 *    Case #1. 
 *    
 *    A few of variables/initializers + a few of conditions EXAMPLE
 * 
 */

namespace MyProject_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you i-value: ");
            int iValue = int.Parse(Console.ReadLine());

            Console.Write("Enter you i-value limit: ");
            int iValueLimit = int.Parse(Console.ReadLine());

            Console.Write("\nEnter you j-value: ");
            int jValue = int.Parse(Console.ReadLine());

            Console.Write("Enter you j-value limit: ");
            int jValueLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLOOP will stop the action if i(j)-value will be less then i(j)-value limit:");
            for (int i = iValue, j = jValue; i < iValueLimit && j < jValueLimit; i++, j++)
            {
                Console.WriteLine("i-value: " + i + "\tj-value:" + j);
                System.Threading.Thread.Sleep(300);
            }

            Console.ReadLine();

            //=============================================================================================================//
            //                                                                                                             //
            //      int i = 0; // Variable have set outside the loops to be visible per total project as local variable    //
            //                                                                                                             //
            //      for (;i < 3; i++)                                                                                      //
            //      {                                                                                                      //
            //          Console.WriteLine("YES " + i);                                                                     //
            //          System.Threading.Thread.Sleep(500); // Slow downs execution of loop/action for 500ms               //
            //      }                                                                                                      //
            //                                                                                                             //
            //      for (; i < 6; i++)                                                                                     //
            //      {                                                                                                      //
            //          Console.WriteLine("NO " + i);                                                                      //
            //          System.Threading.Thread.Sleep(500); // Slow downs execution of loop/action for 500ms               //
            //      }                                                                                                      //
            //                                                                                                             //
            //=============================================================================================================//
        }
    }
}
