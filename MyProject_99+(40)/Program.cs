using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================
 * Anonymous Methods in C# | Using | Writing
 * =========================================
 * 
 *      We discussed that delegates are used to reference any methods that the same signature as that of the delegate. In other words, you can call a
 *  method that can be referenced by a delegate using that delegate object.
 *  
 *      Anonymous methods provide a technique to pass a code block as a delegate parameter. Anonymous methods are the methods without a name, just the body.
 *      
 *      You need not specify the return type in an anonymous method; it's inferred from the return statement inside the method body.
 * 
 * ----------------------------
 * Writing an Anonymous Method:
 * ----------------------------
 * 
 *      Anonymous methods are declared with the creation of the delegate instance, with a 'delegate' keyword. For example:
 *                          
 *                          delegate void NumberChanger(int n);
 *                          ....
 *                          NumberChanger nc = delegate(int x)
 *                          {
 *                              // body of the anonymous method
 *                              Console.WriteLine("Anonymous Method: {0}", x);
 *                          }
 *                          
 *      The delegate could be called both with anonymous methods as well as named in the same way, i.e., by passing the method parameters to the delegate object.
 *      
 *      For example:   nc(10);
 * 
 */

delegate void NumberChanger(int n);

namespace MyProject_139
{
    class Program
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named method: {0}",num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named method: {0}",num);
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            // create delegate instances using anonymous method
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            // calling the delegate using the anonymous method
            nc(10);

            // instantiating the delegate using the named methods
            nc = new NumberChanger(AddNum);

            // calling the delegate using the methods
            nc(5);

            // instantiating the delegate using another named methods
            nc = new NumberChanger(MultNum);

            // calling the delegate using the named methods
            nc(2);

            Console.WriteLine();
        }
    }
}
