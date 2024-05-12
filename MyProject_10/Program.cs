using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * ==========================
 *  *** switch case Statement ***
 * ==========================
 *
 *  - In C#, Switch is a selection statement, and it will execute a single case statement from the list of multiple case statements based on the pattern match with the defined expression.
 *
 *  - Using the switch statement in c#, we can replace the functionality of IF/ELSE if statement to provide better readability for the code.
 *
 *      switch(variable/expresison)
 *         {
 *           case value1:
 *           // Statements to Execute
 *           break;
 *            
 *           case value2:
 *           //Statements to Execute
 *           break;
 *
 *           ....
 *           ....
 *
 *           default:
 *           // Statements to Execute if No Case Matches
 *           break;
 *           }
 *           
 *  #NOTES: - The switch statment contains multiple case labels. The default case executes when no case satisfies the expression;
 *      
 *          - Each switch case must include break or goto keyword;
 *      
 *          - The switch statement can be include cases with string values;
 *      
 *          - A switch expression or case label must be a bool, char, string, integral, enum, or correspunding nullable type;
 *      
 */

namespace MyProject_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value in range 1 to 5: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("You inputted number 1");
                break;

                case 2:
                    Console.WriteLine("You inputted number 2");
                break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("You inputted number 3 or 4 or 5");
                break;

                default:
                    Console.WriteLine("Alert!!! Unknown number!!!");
                break;
            }

            Console.Write("\nInput symbol +/-: ");
            string b = Console.ReadLine();

            switch (b)
            {
                case "+":
                    Console.WriteLine("You inputted +");
                break;

                case "-":
                    Console.WriteLine("You inputted -");
                break;

                default:
                    Console.WriteLine("You inputted unknown symbol");
                break;
            }

            Console.Write("\nInput your char symbol a/b: ");
            char c = char.Parse(Console.ReadLine());
            
            switch (c)
            {
                case 'a': 
                    Console.WriteLine("Your char is a");
                break;

                case 'b': 
                    Console.WriteLine("Your char is b");
                break;

                default:
                    Console.WriteLine("Unknown char you have been inputted!!");
                break;
            }
            Console.WriteLine();
        }
    }
}
