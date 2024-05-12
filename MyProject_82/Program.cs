using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==============================================
 * OOP | Class constructors | Default constuctors
 * ==============================================
 * 
 * --------------
 * #Constructors:
 * --------------
 * 
 *     A constructor is a special method that is used to initialize objects. The advantage of a constructor, it that it's called when an object of class is created.
 *  
 *  -!- NOTES -!- =============================================================================================================
 *  
 *     -!- Note that the constructor name must match the class name, and it cannot have a return type (like void or int etc.).
 *     
 *     -!- Also note that the constructor is called when the object is created.
 *     
 *     -!- All classes have constructors by default: if you don't create a class constructor yourself, C# creates one for you.
 *         However, then you are not able to set initial values for fields.
 * ============================================================================================================================
 * 
 *  -!- NOTE:   -ctor  | snippet for creating constructor syntax C#
 * 
 */

namespace MyProject_82
{
    class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Ford Mustang", "Red" , 1969); // Create an object of the Car Class (this will call the constructor with parameters)
            Console.WriteLine($"{Ford.model} | {Ford.color} | {Ford.year}"); // Print info about Car
        }
    }
}
