using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject_99_Car;
using MyProject_99_MyLogger;

/*
 * ===============================================
 * OOP | const and readonly keywords | Example Car
 * ===============================================
 * 
 * --------
 * Constant:  The \const keyword converts nothing more but a constant. The speciality of this variables is that they need to have a value at compile time and, by default, they are static.
 * --------   This default value means that a single copy of the variable is created and shared among all objects. In case you are using this context via class, you can access them through
 *            the name of the class. It is also important that, for complex applications where the solution is referenced, get a local copy of the constant across assemblies.
 *            
 * --------
 * Readonly:  The \readonly keyword is a special modifier which bears significant resemblance to the \const keyword. It can be used on fields, but not on local variables. 
 * --------   These fields can either be initialized when declared or at the constructor of our object. This keyword ensures that a varibale instance or property of an object
 *            cannot be modified after initialization, and such attempts will result in an exception. While \const is initialized at compile time, \readonly keyword allow the
 *            variable to be initialized either at compile time or runtime.
 *            
 * -----------
 * Conclusion:  The idea behind both keyword is the same. We would like to mark a variable to hold its value during the execution of the application and not allow modification.
 * -----------  The first difference is the timeslot which initializes the \const or \readonly variables. The first, \const, is inialized during compile-time and the latter,
 *              \readonly can only be initialized at the class level.
 *              
 *              Another important difference is that \const variables can be referenced through "ClassName.VariableName", while \readonly can be referenced through the
 *              "InstanceName.VariableName.
 * 
 */

namespace MyProject_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
        }
    }
}
