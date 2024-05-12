using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================
 * Generics in C# | Collections | Benchmarks
 * =========================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
 * 
 *      For many applications, you want to create and manage groups of related objects. There are two ways to group objects: #| by creating arrays of objects.
 *                                                                                                                           #| by creating collections of objects.
 *      Arrays are most useful for creating and working with a fixed number of strongly typed objects.
 *      
 *      Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs
 *  of the application change. For some collections, you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key.
 *  
 *      A collection is a class, so you must declare an instance of the class before you can add elements to that collection.
 *      
 *      If your collection contains elements of only one data type, you can use one of the classes in the System.Collections.Generic namespace. A generic collection enforces type
 *  safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you don't have to determine its data type or convert it.
 * 
 * 
 */

namespace MyProject_130
{
    public class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run(typeof(Program).Assembly);
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
