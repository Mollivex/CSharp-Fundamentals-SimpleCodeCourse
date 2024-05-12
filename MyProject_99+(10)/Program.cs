using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================
 * OOP | Polymorphism | virtual Methods
 * ====================================
 * 
 *      Polymorphism is often referred to as the third pillar of object-oriented programming after encapsulation and inheritance. 
 *  Polymorphism is a Greek word that means "many-shaped" and it has two distict aspects:
 *  
 *          #| At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and
 *             collections or arrays. When this polymorhism occurs, the object's declared type is no longer identical to its run-time type.
 *             
 *          #| Base classes may define and implement 'virtual' methods, and derived classes can 'override' them, which means they provide
 *             their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type
 *             of the object, and invokes that override of the virtual method. In your source code you can call a mehtod on a base class,
 *             and cause a derived class's version of the method to be executed.
 *      
 *      Virtual methods enable you to work with groups of related objects in a uniform way. For example, suppose you have a drawing application
 *  that enables a user to create various kinds of shapes on a drawing surface. You don't know at compile time which specific types of shapes the
 *  user will create. However, the application has to keep track of all the various types of shapes that are created, and it has to update them in
 *  response to user mouse actions.
 *  
 *      You can use polymorphism to solve this problem in two basic steps:
 *      
 *          1| Created a class hierarchy in which each specific shape class derives from a common base class.
 *          
 *          2| Use a virtual method to invoke the appropriate method on any derived class through a single 
 *             call to the base class method.
 * 
 */

namespace MyProject_109
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine is started!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("I'm a car, I go!");
        }
    }
    class Sportcar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("E-ron-don-don");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("I'm a sportcar, I go!");
        }
    }
    class Person
    {
        public void Drive(Car car) 
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new Car());
            Console.WriteLine();

            person.Drive(new Sportcar());
            Console.WriteLine();

        }
    }
}
