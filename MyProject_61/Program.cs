using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==============================================
 * Recursion in C# | Stack overflow | Call stack.
 * ==============================================
 * 
 *  -?- So what is Recursion -?-
 *  
 *      Recursion is a concept in which method calls itself. Every recursive method needs to be terminated, therefore, we need to write a condition in which we check
 *  is the termination condition satisfied. If we don't do that, a recursive method will end up calling itself endessly.
 * 
 *      A function that calls itself is known as a recursive function. And, this way is known as recursion.
 *  A physical world example would be to place two parallel mirrors facing each other. Any object in between them would be reflected recursively.
 * 
 *  #NOTE: Remember that if a recursive function uses local variables, each call will create a new set of local variables. Every time the function is called,
 *         the variables will represent a different set of values. Each set of values will be stored on the stack memory.
 *  
 *  #NOTE: This is how recursive functions generally work - they call themselves.
 *         If you notice that a function repeatedly calls itself inside of the function body, that indicates that the function is recursive.
 *         
 *  #NOTE: One more crucial thing to remember is that recursive functions have base condition visible inside them. This means that there must be some base condition
 *         for the recursion to end. The situation is comparable to a loop in that an infinite loop results if there is no condition to break the loop.
 *         
 *  #NOTE: Therefore, there must be some means of ending the recursion to prevent unlimited calling. The function must be called for the first time before it starts
 *         calling itself repeatedly and repeatedly after that. Therefore, there must be a circumstance in which it must end.
 *  
 *  #NOTE: In C# the function will call itself if the condition is true. In this case, if the condition turns out to be false, it stops calling
 * 
 * ===================================================================================================================================================================
 * 
 *  -?- How Recursion Works -?-
 * 
 *      public static void Main()
 *      {
 *          ... .. ...
 *          recurse()
 *          ... .. ...
 *      }
 *      
 *      static void recurse()
 *      {
 *          ... .. ...
 *          recurse()
 *          ... .. ...
 *      }
 *      
 *      In the above example, we have called the recurse() method from inside the Main method (normal method call). And, inside the recurse() method, we are again
 *  calling the same recuse() method. This is a recursive call.
 *  
 *      To stop the recursive call, we need to provide some conditions inside the method. Otherwise, the method will be called infinitely.
 *      
 *      Hence, we use the if...else statement (or similar approach) to terminate the recursive call inside the method.
 * 
 * ===================================================================================================================================================================
 * 
 *  -?- Pros and Cons of Recursion -?-
 * 
 *  #Advantages of Recursion:
 *  
 *      -!- Recursion will keep track of information pertaining to function calls.
 *      -!- Recursion will be used to evaluate the stack.
 *      -!- Recursion will be used to evaluate the prefix, postfix, and infix notations.
 *      
 *  #Disadvantages of Recursion:
 *  
 *      -!- Due to stack overlap, the process is extremely slow.
 *      -!- Stack overflow can be produced by the recursive program.
 *      -!- Infinite loops can be made by the recursive program.
 *      
 *  
 */

namespace MyProject_61
{
    public class Program
    {
        static void Foo (int value)
        {
            Console.WriteLine (value);

            if (value >= 10)
                return;

            value++;
            Foo(value);
        }

        /// <summary>
        /// An object class which declares the two elements - Value (int) and Child (Item)
        /// </summary>
        public class Item
        {
            public int Value { get; set; }

            public Item Child { get; set; }
        }

        /// <summary>
        /// A method which creates elements of Item object class
        /// </summary>
        /// <returns></returns>
        static Item InitItem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }

        /// <summary>
        /// A method to print Item objects class
        /// </summary>
        /// <param name="item"></param>
        static void Print(Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }

        public static void Main(string[] args)
        {
            Item item = InitItem(); 

            //Print(item);

            //We can output our data with help of loops instead of recursive method Print()
            for (Item i = InitItem(); i != null; i = i.Child)
            {
                Console.WriteLine(i.Value); 
            }
        }
    }
}
