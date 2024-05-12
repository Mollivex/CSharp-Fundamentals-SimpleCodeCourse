using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  =========================
 *  #_METHODS and FUNCTIONS_#
 *  =========================
 *  
 *  #NOTE: Methods and Functions are the same in C#.
 *  
 *      $ However, Methods are used in C# and are functions that operate through a designated class. A method is a group of statements that together perform a task. 
 *  Every C# program has at least one class with a method named Main.
 *  
 *      $ A method is a block of code which only runs when it is called. You can pass data, known as parameters, into a method.
 *  Methods are used to perform certain actions, and they are also known as functions.
 *  
 *  =================
 *  #Create a Method:
 *  =================
 *  
 *      $ A method is defined with the name of the method, followed by parentheses (). 
 *  C# provides some pre-defined methods, which you already are familiar with, such as Main(), but you can also create your own methods to perform certain actions:
 *  
 *  ==========================================
 *  #Create a method inside the Program class:
 *  ==========================================
 *  
 *           class Program
 *           {
 *              static void MyMethod() 
 *              {
 *                 // code to be executed
 *              }
 *           }
 *           
 *  ===================
 *  #Example Explained:
 *  ===================
 *  
 *      $ MyMethod() is the name of the method static means that the method belongs to the Program class and not an object of the Program class. 
 *  void means that this method does not have a return value.
 *  
 *  *** Note #1: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.
 *  
 *  ===========
 *  #Syntax C#:
 *  ===========
 *  
 *          modificator returnedValue_type methodName(parameters)
 *          {
 *             body of method;
 *          }
 *          
 *  *** Note #2: Methods must be written after CLASSES
 *  
 *  *** Note #3: In C# it's not neccesary to put methods before MAIN. It can be inserted after.
 */

namespace MyProject_44
{
    class Program
    {
        static int Sum (int value_1,int value_2)
        {
            return value_1 + value_2;
        }

        static void Result(int result)
        {
            Console.WriteLine("Sum result is: " + result);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int a, b, c;

                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error! Try again!");
                    Console.ReadLine();
                    continue;
                }
                c = Sum(a, b);

                Result(c);

                Console.WriteLine("================");
                Console.ReadLine();
            }
        }
    }
}
