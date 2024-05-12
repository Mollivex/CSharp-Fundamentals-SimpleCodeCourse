using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================
 * Reflection in C# | Example
 * ==========================
 * 
 *      https://www.tutorialspoint.com/csharp/csharp_reflection.htm#
 * 
 *      In this example, we use the DeBugInfo attribute created in the previous MyProject_132 and use reflection
 *  to read metadata in the Rectangle class.
 * 
 */

namespace MyProject_133
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]

    public class DeBugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        public int BugNo => bugNo;
        public string Developer => developer;
        public string LastReview => lastReview;
        public string Message => message;
    }
    [DeBugInfo(45, "Zara Ali", "12/8/2023", message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2023", message = "Unused variable")]
    class Rectangle
    {
        // member variables
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }
       
        [DeBugInfo(55, "Zara Ali", "19/10/2023", message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }
        [DeBugInfo(56, "Zara Ali", "19/10/23")]
        public void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine();
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4.5, 5.8);
            r.Display();
            Type type = typeof(Rectangle);

            //iterating through the attributes of the Rectangle class
            foreach (object attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;

                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                    Console.WriteLine();
                }
            }
            // iterating through the method attributes
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach(Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi = (DeBugInfo)a;

                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
