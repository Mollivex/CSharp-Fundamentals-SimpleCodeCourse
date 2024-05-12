using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================
 * OOP | Interfaces in C# | Introduction
 * =====================================
 * 
 *      Another way to achieve abstraction in C#, is with interfaces.
 *      
 *      Interface in C# is a blueprint of a class. It's like abstract class because all the methods which are declared inside the interface
 *  are abstract methods. It cannot have method body and cannot be instantiated.
 *  
 *      It's used to achieve multiple inheritance which can't be achieved by class. It's used to achieve fully abstraction because it cannot
 *  have method body.
 *  
 *      Its implementation must be provided by class or struct. The class or struct which implements the interface, must provide the implementation
 *  of all the methods declared inside the interface.
 *  
 * -------------------------------------------------------------------------------------------------------------------------------------------
 * NOTE: Interface methods are public and abstract by default. You cannot explicitly use public and abstract keywords for an interface method.
 * -------------------------------------------------------------------------------------------------------------------------------------------
 * 
 *      Interfaces includes the declarations of related functionalities. The entities that implement the interface must provide the implementation
 *  of declared functionalities.
 *      
 *      In C#, an interface can be defined using the 'interface' keyword. An interface can contain declarations of methods, properties, indexers, and
 *  events. However, it cannot contain instance fields.
 *  
 * -------------------------------------------------------------------------------------------------------------------------------------------
 * NOTES:   #| Like abstract classes, interfaces cannot be used to created objects
 * 
 *          #| Interface methods don't have a body - the body is provided by the "implement" class
 * 
 *          #| An interface can contain declarations of methods, properties, indexers, and events.
 *          
 *          #| Default interface methods with implementation body are supported from C# 8.0.
 *          
 *          #| An interface cannot contain constructors and fields.
 *          
 *          #| Interface members are by default abstract and public.
 *          
 *          #| You cannot apply access modifiers to interface members. Although, C# 8.0 onwards, you may use private, protected, internal, 
 *             public, virtual, abstract, sealed, static, extern, and partial modifiers on certain conditions.
 * -------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * 
 */

namespace MyProject_114
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();

            dataProcessor.ProcessData(new APIDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new DbDataProvider());
        }
    }
}
