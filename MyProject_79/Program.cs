using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =================================
 * OOP | Class methods | Car Example
 * =================================
 * ----------------
 * Declaring method
 * ----------------
 *      Method is the building block of object-oriented programming. It combines related code together and makes program easier.
 *  In C# method declaration, you can declare method by following way:
 *  
 *              <Access modifier> <Return type> <Method Name> (Parameter list)
 *              {
 *                  Code block (body of the method);
 *              }
 * --------------
 * Calling method
 * --------------         
 *      After creating method, you need to call it in Main() method to execute. In order to call method, you need to create object
 *  of containing class, then followed by dot(.) operator you can call the method. If method is static, then there is no need to   
 *  create object and you can directly call if followed by class name.
 *  
 * ---------------------------
 * Static Method and Variables
 * ---------------------------
 *      Whenever you write a function or declare a variable, it doesn't create an instance in a memory until you create an object
 *  of the class. But it you declare any function or variable with a static modifier, it directly creates an instance in a memory 
 *  and acts globally. The static modifier doesn't reference any object.
 *  
 *      HOW TO: It is very easy to create static modifier with variables, functions and classes. Just put <static> keyword before
 *              the return data type of method.
 * -------------
 * Main() method
 * -------------
 *      In C# programming the Main() method is where program starts execution. It is the main entry point of program that executes all
 *  objects and invokes method to execute. The can be only one Main() method in C#. However, the C# Main() method can be void or
 *  int return type. It must be inside a class or stuct and must be declared with static modifier. It is the main place where a program
 *  starts the execution and end. The Main() method can have a parameter and these parameters are known as zero-indexed command line arguments.
 *  
 *  #Here we have example with Car object of using methods in classes below:
 *  
 */

namespace MyProject_79
{
    class Car
    {
        private int speed = 0;

        public void PrintSpeed()
        {
            if (speed == 0)
                Console.WriteLine("Stand still...");
            else if (speed > 0)
                Console.WriteLine($"Move forward with speed {speed} km/h");
            else if (speed < 0)
                Console.WriteLine($"Move backward with speed {-speed} km/h");
        }

        public void DriveForward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t== Car #1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();

            Console.WriteLine("\n");

            Console.WriteLine("\t== Car #2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();
        }
    }
}
