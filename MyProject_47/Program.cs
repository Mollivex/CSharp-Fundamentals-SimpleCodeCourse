using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  =====================
 *  #METHODS. Overloading
 *  =====================
 *  
 *  - In C#, there might be two or more methods in a class with the same name but different numbers, types, and order of parameters, it is called method overloading. For example:
 *  
 *                       void display() { ... };
 *
 *                       void display(int a) { ... };
 *
 *                       float display(double a) { ... };
 *
 *                       float display(int a, float b) { ... };
 *  
 *  Here, the display() method is overloaded. These methods have the same name but accept different arguments.
 *  
 * =============================================================================================================
 *
 *  - With method overloading, multiple methods can have the same name with different parameters:
 *  
 *                      int MyMethod(int x);
 *          
 *                      float MyMethod(float x);
 *          
 *                      double MyMethod(double x, double y);
 *  
 *  - #NOTE: The return types of the above methods are not the same. It is because method overloading is not associated with return types. 
 *  Overloaded methods may have the same or different return types, but they must have different parameters.
 *  
 *  - #NOTE: If you want to comment your methods into the classes, you might type "///" and then VS will generate the comment template. 
 *  
 */

namespace MyProject_47
{
    class Program
    {
        /// <summary>
        /// Sums two int-type values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Sums two double-type values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        /// <summary>
        /// Sums three double-type values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double PlusMethod(double x, double y, double z)
        {
            return x + y + z;
        }
        /// <summary>
        /// Sums three int-type values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int PlusMethod(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            // Consider the following example, which have four methods that add different number of values of different type:

            int firstValueInt, secondValueInt, thirdValueInt;
            double firstValueDouble, secondValueDouble, thirdValueDouble;

            // First PlusMethod-overload INT
            Console.WriteLine("Enter two INT-values to sum them: ");
                firstValueInt = int.Parse(Console.ReadLine());
                secondValueInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Your INT sum result is: " + PlusMethod(firstValueInt, secondValueInt));
            
            // Second PlusMethod-overload DOUBLE
            Console.WriteLine("\nEnter two DOUBLE-values to sum them: ");
                firstValueDouble = double.Parse(Console.ReadLine());
                secondValueDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Your DOUBLE sum result is: " + PlusMethod(firstValueDouble, secondValueDouble));

            // Third PlusMethod-overload INT
            Console.WriteLine("\nEnter three INT-values to sum them: ");
                firstValueInt = int.Parse(Console.ReadLine());
                secondValueInt = int.Parse(Console.ReadLine());
                thirdValueInt = int.Parse(Console.ReadLine());    
            Console.WriteLine("Your INT sum result is: " + PlusMethod(firstValueInt, secondValueInt, thirdValueInt));

            // Fourth PlusMethod-overload DOUBLE
            Console.WriteLine("\nEnter three DOUBLE-values to sum them: ");
                firstValueDouble = int.Parse(Console.ReadLine());
                secondValueDouble = int.Parse(Console.ReadLine());
                thirdValueDouble = int.Parse(Console.ReadLine());
            Console.WriteLine("Your DOUBLE sum result is: " + PlusMethod(firstValueDouble, secondValueDouble, thirdValueDouble));

            Console.WriteLine();
        }
    }
}
