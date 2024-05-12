using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===========================================
 * OOP | Constructors | Constructor Parameters
 * ===========================================
 * 
 * ------------------------
 * #Constructor Parameters:     Constructors can also take parameters, which is used to initialize fields.
 * ------------------------
 *                              The following example adds a string modelName parameter to the constructor. Inside the constructor we set model to modelName (model = modelName). When we call
 *                              the constructor, we pass a parameter to the constructor("Mustang"), which will set the value of model to "Mustang":
 * 
 *  #TIP: Just like other methods, constructors can be overloaded by using different numbers of parameters.
 * 
 * --------------------
 * #Constructor syntax:     A constructor is a method whose name is the same as the name of its type. Its method signature includes only an optional access modifier, the method name and its
 * --------------------     parameter list; it doesn't include a return type.
 *  
 * -------------------------
 * #Constructor overloading:    We can overload class constructors just like methods. We can create multiple of variations of constructors with different parameters by name, type and etc inside.
 * -------------------------    And when we create a new class object, we can choose constructor with certain parameters for this new object.
 * 
 *  -!- NOTE:   -ctor  | snippet for creating constructor syntax C#
 *  
 */

namespace MyProject_83
{
    class Point
    {
        /// <summary>
        /// Set XY coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            _x = x; 
            _y = y;
        }

        /// <summary>
        /// Set Z coordinate
        /// </summary>
        /// <param name="z"></param>
        public Point(int z)
        {
            _z = z;
        }

        /// <summary>
        /// Set XYZ coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        private int _x;
        private int _y;
        private int _z;

        /// <summary>
        /// Print coordinates
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}\tZ: {_z}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert values of XYZ coordinates:");
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Z: ");
            int z = int.Parse(Console.ReadLine());

            Point point = new Point();
            point.Print();
        }
    }
}
