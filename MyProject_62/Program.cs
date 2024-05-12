using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================================
 * Recursion in C# | Examples of applications
 * ==========================================
 * 
 *  -!- Example #1: 
 *  Create an application which calculates the sum of all the numbers from n to m recusively.
 *      
 *  #CodeExplanation:
 *      
 *      The method CalculateSumRecursively is our recursive method that calculates the sum of the numbers from n to m. The first thing we do is to set our sum to the value of n.
 *  Then, we check if the value of n is less than value of m. If it is, we increase the value of n by 1 and add to our sum a result of the same method but with the increased n.
 *  If it's not, we just return the value of the sum variable.
 *  
 *      The C# will reserve memory storage for every recursive method so that the values from previous method are not overriden.
 *      
 *  ============================================================================================================================================================================    
 *  ============================================================================================================================================================================    
 *  
 *  -!- Example #2: 
 *  Create an application which prints out how many times the number can be divided by 2 evenly.
 * 
 *  ============================================================================================================================================================================    
 *  ============================================================================================================================================================================    
 * 
 *  -!- Example #3:
 *  Create an application which finds factorial of a number using recursion.
 * 
 *      The factorial of a positive number n is given by:
 *      
 *                      factorial of n (n!) = 1 * 2 * 3 * 4...n
 * 
 *  #CodeExplanation:
 *  
 *      We have a method named Factorial(). We have passed a variable num as an argument in Factorial().
 *  The Factorial() is called from the Main() method. Inside Factorial(), notice the statement:
 *  
 *                      return num * Factorial(num - 1);
 *  
 *      Here, the Factorial() method is calling itself. Initially, the value of num inside Factorial() 
 *  is 4 (for example). During the next recursive call, 3 is passed to the Factorial() method. This process 
 *  continues until num is equal to 0.
 *  
 *      When num is equal to 0, the if statement returns true hence 1 is returned. Finally, the accumulated
 *  result is passed to the Main() method.
 * 
 */

namespace MyProject_62
{
    class Program
    {
        /// <summary>
        /// Calculates the sum of all the numbers from n to m recursively
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int CalculateSumRecusively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecusively(n, m);
            }
            
            return sum;
        }

        /// <summary>
        /// Prints out how many times the number can be divided by 2 evenly
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CountDivisions(double number)
        {
            int count = 0;

            if (number > 0 && number % 2 == 0)
            {
                count++;
                number /= 2;
                return count += CountDivisions(number);
            }
            return count;
        }

        /// <summary>
        /// Find factorial of a number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Factorial(int value)
        {
            // termination condition
            if (value == 0)
                return 1;
            else
                // recursive call
                return value * Factorial(value - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Example #1: Create an application which calculates the sum of all the numbers from n to m recusively:");
            Console.WriteLine("=====================================================================================================");

            Console.Write("\nEnter number n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number m: ");
            int m = int.Parse(Console.ReadLine());

            int sum = CalculateSumRecusively(n, m);

            Console.WriteLine("Your SUM result is: " + sum);

            Console.ReadLine();

            Console.WriteLine("========================================================================================================");
            Console.WriteLine("Example #2: Create an application which prints out how many times the number can be divided by 2 evenly:");
            Console.WriteLine("========================================================================================================");

            Console.Write("Enter your number: ");
            double number = double.Parse(Console.ReadLine());

            int count = CountDivisions(number);
            Console.WriteLine($"Total number of divisions is: {count}");

            Console.ReadLine();

            Console.WriteLine("========================================================================================================");
            Console.WriteLine("Example #3: Create an application which finds and prints factorial of a number using recursion methods:");
            Console.WriteLine("========================================================================================================");

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // calling the recursive function
            int fact = Factorial(num);

            Console.WriteLine("Factorial of {0} is {1}", num , fact);

            Console.ReadLine();
        }
    }
}
