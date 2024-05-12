using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================
 * OOP | Polymorphism | Example Shape
 * ==================================
 * 
 *      In this example, the Shape class contains the two coordinates x, y, and the Area() virtual method. Different shape classes such
 *  as Circle, Cylinder, and Sphere inherit the Shape class and the surface area is calculated for each figure. Each derived class has
 *  its own override implementation of Area().
 *  
 *      Notice that inherited classes Circle, Cylinder, and Sphere all use constructors the initialize the base class, as shown in the 
 *  following declaration.
 *  
 *                      public Cylinder(double r, double h) : base(r,h) {}
 *      
 *      The following program calculates and displays the appropriate area for each figure by invoking the appropriate implementation of
 *  the Area() method, according to the object that is associated with the method.
 * 
 */

namespace MyProject_111
{
    class ProgramShape
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }
            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual double Area()
            {
                return x * y;
            }
        }
        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }
            public override double Area()
            {
                return PI * x * x;
            }
        }
        public class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }
            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y; 
            }
        }
        public class Sphere : Shape   
        {
            public Sphere(double r) : base(r, 0)
            {
            }
            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);

            // Display results
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
        }
    }
}
