using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================================
 * OOP | Abstraction | Classes and Methods #2
 * ==========================================
 * 
 *      The abstract classes are used to achieve abstraction in C#.
 *      
 *      The Abstract classes are typically used to define a base class in the class hierarchy. Or in other words,
 *  an abstract class is an incompelte class or a special class we can't be instantiated. The purpose of an abstract
 *  class is to provide a blueprint for derived classes and set some rules that the derived classes must implement
 *  when they inherit an abstract class. We can use an abstract class as a base class and all derived classes must
 *  implement abstract definitions.
 *  
 *      Abstraction is one of the important concepts of object-oriented programming. It allows us to hide 
 *  unneccesary details and only show the needed information.
 *      
 *      This helps us to manage complexity by hiding details with a simpler, higher-level idea.
 *      
 *      A practical example of abstraction can be motorbike brakes. We know what a brake does. When we apply
 *  the brake, the motorbike will stop. However, the working of the brake is kept hidden from us.
 *  
 *      The major advantage of hiding the working of the brake is that now the manufacturer can implement brakes
 *  differently for different motobikes. However, what brake does will be the same.
 * 
 */

namespace MyProject_113
{
    abstract class MotorBike
    {
        public abstract void brake();
    }
    class SportBike : MotorBike
    {
        // provide implementation of abstract method:
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }
    }
    class MountainBike : MotorBike
    {
        // provide implementation of abstract method:
        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brakes");
        }
    }
    class AbstractClass
    {
        static void Main(string[] args)
        {
            // create an instance of SportBike class:
            SportBike bike1 = new SportBike();
            bike1.brake();

            // create an instance of MountainBike class:
            MountainBike bike2 = new MountainBike();
            bike2.brake();

            Console.ReadLine();
        }
    }
}
/*
 *      In the above example, we have created an abstract class MotorBike. It has an abstract method brake().
 *      
 *      As brake() is an abstract method the implementation of brake() in MotorBike is kept hidden.
 *      
 *      Every motorbike has a different implementation of the brake. This is why SportsBike makes its own
 *  implementation of brake() and MountainBike makes its own implementation of brake().
 */