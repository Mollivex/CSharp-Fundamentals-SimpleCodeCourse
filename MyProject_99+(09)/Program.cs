using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =============================================
 * OOP | Inheritance | protected Access Modifier
 * =============================================
 * 
 *      The protected keyword implies that the object is accessible inside the class and in all classes
 *  that derive from that class.
 *  
 * -----------------------------------------------------------------------------------------------------------
 *      #| You can see the example of using protected keyword below |#
 *      
 *      First, we declare a Width and a Height property with the protected access modifier, meaning that
 *  they are only accessible from within the Shape class and its derived classes.
 * -----------------------------------------------------------------------------------------------------------
 *  
 */

namespace MyProject_108
{
    /// <summary>
    /// Let's create a class Shape:
    /// </summary>
    public class Shape
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        /// <summary>
        /// The GetArea() method is a public method and we mark it as virtual, so a derived class can override it.
        /// </summary>
        /// <returns></returns>
        public virtual int GetArea()
        {
            return Width * Height;
        }
    }

    /// <summary>
    /// Now, let's create a class that inherits from Shape:
    /// </summary>
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // The use of the protected access modifiers in Shape allows the derived Rectangle class to access the Width
            // and Height fields inherited from the base class:

            var rectangle = new Rectangle(10, 5);

            var area = rectangle.GetArea();

            Console.WriteLine(area);

            // Thus, we use the protected access modifier in C# for creating specialized derived classes that can access
            // members of a base class.
        }
    }
}
