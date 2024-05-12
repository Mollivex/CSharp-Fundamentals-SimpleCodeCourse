using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ======================================
 * OOP | Inheritance and Access Modifiers
 * ======================================
 * 
 *      In inheritance, an object acquires all the properties and behaviours of its parent object automatically.
 *  It allows reusability of the code and we even extend or modift the behaviours which are defined in other class.
 *  
 *      We can derive a class from more than one class or interface and it can inherit data and functions from
 *  multiple base classes or interfaces.
 *  
 *    #Derived classes syntax:      <access-modifier> class <base_class>
 *                                  {
 *                                      ... ... ... ... 
 *                                  }
 *                                  class <derived_class> : <base_class>
 *                                  {
 *                                      ... ... ... ...
 *                                  }
 * 
 * ---------------------------------------------------------------------------------------------------------------------------
 * Access Modifiers:    #| Public    :   It has no limits which means any members or types defined as the public can be
 * -----------------                     accessed within the class, assembly and even outside the assembly.
 *                      
 *                      #| Private   :   Limits the accessibility of a member within the defined type. For example, if a
 *                                       variable or a function is being created in ClassA and declared as private, then
 *                                       another ClassB can't access that.
 *                      
 *                      #| Protected :   Plays a role only when inheritance is used. Protected type or member becomes
 *                                       accessible only when a child is inherited by the parent.
 *                  
 *                      #| Internal  :   Internal plays an important role when you want your class members to be accessible
 *                                       within the assembly. Hence, if you have a C# project that has ClassA, ClassB and
 *                                       ClassC, then any internal tyoe and members will become accessible across the classes
 *                                       within the assembly.
 *                      
 *                      #| Protected :   It's combination of protected and internal both. It will be accessible within the 
 *                         internal      the assembly due to its internal flavor and also via inheritance due to its protected
 *                                       flavor.
 * ----------------------------------------------------------------------------------------------------------------------------
 * 
 * #NOTE: The \protected access modifier works like a \private modifier, but a \protected modifier can ONLY be seen at the class level, not seen at the object class level.
 *        Therefore, \protected modifier can be used only when we are realize inheritance.
 * 
 */

namespace MyProject_107
{
    public class A
    {
        public int publicField;

        private int privateField;

        protected int protectedField;

        public A()
        {
            Console.WriteLine(publicField); // field available
            Console.WriteLine(privateField); // field available
            Console.WriteLine(protectedField); // field available

            Foo();
        }
        public void Foo()
        {
            Console.WriteLine(publicField); // field available
            Console.WriteLine(privateField); // field available
            Console.WriteLine(protectedField); // field available
        }
        public void Bar()
        {
            Foo();
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine(publicField); // field available

            //Console.WriteLine(privateField); // field not available

            Console.WriteLine(protectedField); // field available
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField); // field available
            //Console.WriteLine(a.privateField); // field not available
            //Console.WriteLine(a.protectedField); // field not available

            B b = new B();
            Console.WriteLine(a.publicField); // field available
            //Console.WriteLine(a.privateField); // field not available
            //Console.WriteLine(a.protectedField); // field not available

            b.Foo();
        }
    }
}
