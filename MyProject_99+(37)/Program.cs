using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============================================================
 * Delegates in C# | Parameters | Multicasting | Anonymous methods
 * ===============================================================
 * 
 *      A delegate can call more than one method when invoked. This is reffered to as multicating. To add an extra method to the delegate's list 
 *  of methods - the invocation list - simply requires adding two delegates using the addition or addition assignment operators ('+' or '+='). For example:
 *  
 *                          var obj = new MethodClass();
 *                          Del d1 = obj.Method1;
 *                          Del d2 = obj.Method2;
 *                          Del d3 = obj.Method3;
 *                          
 *                          // Both types of assignment are valid
 *                          Del allMethodsDelegate = d1 + d2;
 *                          allMethodsDelegate = d3;
 *                          
 *      Using this property of delegates you can create an invocation list of methods that will be called when a delegate is invoked. 
 *  This is called multicasting of a delegate.  
 *       
 *      Delegates with more than one method in their invocation list derive from MulticastDelegate, which is a subclass of System.Delegate. 
 *  The above code works in either case because both classes support GetInvocationList.
 *      
 *      In C# anonymous methods are unnamed methods in a code that can be defined using the delegate keyword. They only require a bpidy and
 *  not a name or a return type. Anonymous methods allow users to write inline codes rather than explicit methods.
 * 
 */

namespace MyProject_136
{
    public class Program
    {
        // Delegate without Parameters
        public delegate void WithoutParameters();
        public static void ShowMessage() => Console.WriteLine("Have fun!");

        // Delegate with Parameters
        public delegate string WithParameters(string str1, string str2);
        private static string ShowMessage(string str1, string str2)
        {
            Console.WriteLine($"{str1}, {str2} - Have fun!");
            return "The end";
        }

        // Delegate multicasting
        public delegate void DelegateMulticasting();
        private static void ShowMessage1() => Console.WriteLine("Have fun!");
        private static void ShowMessage2() => Console.WriteLine("See you later!");

        // Delegate anonymous methods
        public delegate void DelegateAnonymous();

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------EXAMPLE_#1(Delegate without parameters)-----------------");
            
            WithoutParameters noParameter = new(ShowMessage);
            noParameter();
           
            Console.WriteLine("----------------------------------------------------------------------------");


            Console.WriteLine("\n--------------------EXAMPLE_#2(Delegate with parameters)--------------------");
            
            WithParameters withParameters = new(ShowMessage);
            string value = withParameters("Boris", "Ivan");
            Console.WriteLine(value);
            
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("\n--------------------EXAMPLE_#3(Delegate multicasting)-----------------------");
           
            DelegateMulticasting multiDeleg1 = new(ShowMessage1);
            multiDeleg1 += ShowMessage2;
            multiDeleg1();
            
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("\n--------------------EXAMPLE_#4(Delegate anonymous methods)------------------");

            DelegateAnonymous anonymousMethod = delegate ()
            {
                Console.WriteLine($"Have fun!");
            };
            anonymousMethod();
            
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
