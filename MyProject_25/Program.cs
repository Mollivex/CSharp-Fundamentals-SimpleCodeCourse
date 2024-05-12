using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  #MY_SimpleCode_PYRAMIDS
 * 
 *  HOMEWORK #4. (variant made by #MYSELF)
 *  
 *  To make pyramids using only nested loops (without if-else)
 *  
 *  
 *  Output example:
 *  
 *  -----------------TYPE 1--------------------------------------------------------
 *  
 *  #
 *  ##
 *  ###
 *  ####
 *  
 *  ####
 *  ###
 *  ##
 *  #
 *  
 * -----------------TYPE 2--------------------------------------------------------
 *  
 *     #
 *    ##
 *   ###
 *  ####
 *  
 *  ####
 *   ###
 *    ##
 *     #
 *     
 * -----------------TYPE 3--------------------------------------------------------
 *     #
 *    ###
 *   #####
 *  #######
 *  
 */

namespace MyProject_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                try
                {
                    Console.Write("Enter height of pyramids:");
                    int height = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Print pyramids TYPE #1");
                    Console.WriteLine();

                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(); // space

                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = height; j >= i; j--)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(); // space

                    //=============================================================================================================================

                    Console.WriteLine("Print pyramids TYPE #2");
                    Console.WriteLine(); // space


                    for (int i = 0; i <= height; i++)
                    {
                        for (int j = height; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(); // space

                    for (int i = 0; i <= height; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = height; j >= i; j--)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(); // space

                    //=============================================================================================================================

                    Console.WriteLine("Print pyramids TYPE #3");
                    Console.WriteLine(); // space

                    for (int i = 1; i <= height; i++) // Total number of layer for pramid  
                    {
                        for (int j = 1; j <= (height - i); j++) // Loop For Space  
                            Console.Write(" ");

                        for (int j = 1; j <= i; j++) //increase the value  
                            Console.Write('*');

                        for (int j = (i - 1); j >= 1; j--) //decrease the value  
                            Console.Write('*');

                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!!!");
                    Console.ReadLine();
                }
            }
        }
    }
}
