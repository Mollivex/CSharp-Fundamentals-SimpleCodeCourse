using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================================
 * OOP | Classes and Objects in C# | Class instance
 * ================================================
 * 
 * ----------------------
 *   -?- What is OOP -?-
 * ----------------------
 *     OOP stands for Object-Oriented Programming.
 *     
 *     Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming 
 *  is about creating objects than contain both data and methods.
 *      
 *     #Object-oriented programming has several advantages over procedural programming:
 *  
 *  - OOP is faster and easier to execute;
 *  - OOP provides a clear structure for the programs;
 *  - OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug;
 *  - OOP makes it possible to create full reusable applications with less code and shorter development time;
 *  
 *  #TIP: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are
 *        common for the application, and place them at a single place and reuse them instead of repeating it.
 *        
 * ---------------------------------------
 *   -?- What are Classes and Objects -?-
 * ---------------------------------------
 *      Classes and Objects are two main aspects of object-oriented programming.
 *   
 *   #Difference between class and objects:
 *  __________________________
 *  |  Class    |   Objects  |
 *  |-----------|------------|
 *  |  Fruit    |  Apple     |
 *  |           |  Banana    |
 *  |           |  Mango     |  
 *  |-----------|------------|
 *  |   Car     |  Volvo     |
 *  |           |  BMW       |
 *  |           |  Mercedes  |
 *  |___________|____________|        
 *  
 *      So, a class is a template for objects, and an object is an instance of a class.
 *      
 *      When the individual objects are created, they inherit all the variables and methods from the class.
 *      
 *      Everything in C# is associated with classes and objects, along with its attributes and methods.
 *  For example: in real life, a car is an object. The car has attributes, such as weight and color,
 *  and methods, such as drive and brake.
 *      A Class is like an object constructor, or a "blueprint" for creating objects.
 *      
 * -------------------------
 *   -?- Create a Class -?-
 * -------------------------
 *      When a variable is declared directly in a class, it's often referred to as a field (or attribute).
 *      Create a class named "Car" with a variable color:
 *  
 *                    class Car 
 *                    {
 *                      string color = "red";
 *                    }
 *                    
 *      It's not required, but it's a good practice to start with an uppercase first letter when naming classes. 
 *  Also, it's common that the name of the C# file and the class matches, as it makes our code organized. 
 *  However, it's not required (like in Java).
 *  
 * -------------------------
 *   -?- Create an Object -?-
 * -------------------------
 *      An object is created from a class. We have already created the class named Car, so now we can use this 
 *  to create objects.
 *      To create an object of Car, specify the class name, followed by the object name, and use the keyword new:
 *      
 *      Create an object called "myObj" and use it to print the value of color:
 *      
 *                class Car 
 *                {
 *                   string color = "red";
 *
 *                   static void Main(string[] args)
 *                   {
 *                      Car myObj = new Car();
 *                       Console.WriteLine(myObj.color);
 *                   }
 *                }
 * 
 *  #Note that we use the dot syntax ( . ) to access variables/fields inside a class (myObj.color)
 *  
 */

namespace MyProject_76 
{
    /// <summary>
    /// Point color: red, green, yellow, blue, black
    /// </summary>
    enum Color
    {
        Red,
        Green,
        Yellow,
        Blue,
        Black
    }
    
    /// <summary>
    /// Point info: x-coordinate, y-coordinate, point color
    /// </summary>
    class Point // user data type
    {
        // class fields
        public int x;
        public int y;
        public Color color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(); // class object
            p.x = 3;
            p.y = 7;
            p.color = Color.Red;
            Console.WriteLine($"Point #1. X: {p.x} | Y: {p.y} | Color: {p.color}");

            Point p2 = new Point(); // class object
            p2.x = 5;
            p2.y = 2;
            p2.color = Color.Green;
            Console.WriteLine($"Point #2. X: {p2.x} | Y: {p2.y} | Color: {p2.color}");

            // System.NullReferenceException 
            Point p3 = new Point();
            p3 = null; // if we have a null value in an object of a reference type, we cannot next assign any value to that object and we'll get an exception
            p3.x = 1;
            p3.y = 3;
            p3.color = Color.Yellow;
        }
    }
}
