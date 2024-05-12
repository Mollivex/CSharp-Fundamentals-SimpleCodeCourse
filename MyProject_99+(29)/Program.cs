using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================================
 * Generics in C# | Generic Classes and Collections
 * ================================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/standard/generics/collections
 *      https://www.simplilearn.com/tutorials/c-sharp-tutorial/collections-in-c-sharp
 *      
 *      C# collections are made to more effectively organize, store and modify comparable data. Adding, deleting, discovering, and inserting data into the collection
 *  are all examples of data manipulation. These classes supports stacks, queues, lists, and hash tables. Most collections implement the same interfaces.
 *  
 *      There are several applications for collection classes, such as dynamic memory allocation for elements and index-based access to list of objects. 
 *  These classes construct collections of objects of the Object class, the building blocks of all other C# data types.
 * 
 *    #| Collections are majorly classified into two types: 1. Generic Collections (List, Dictionary, Sorted List, Stack, Queue)
 *                                                         2. Non-generic Collections (ArrayList, HashTable, Sorted List, Stack, Queue)
 *      
 *    #| A Generic collections provides the type safety without derivation from a basic collection type and the implementation of type-specific members. 
 *  The Generic Collection classes are found in the namespace System.Collections.Generics. Internally, Generic Collections store elements in arrays of 
 *  their respective types.
 *  
 *    #| Non-generic collections are specialized data storage and retrieval classes that handle stacks, queue, lists and hash tables. The System.Collections namespace 
 *  contains the Non-generic Collection classes. Non-generic collections store elements in object arrays internally, allowing them to hold any data type.
 * 
 * ------------------------------
 * Benefits of Collections in C#:   #| Generic collections work faster than non-generic ones and 
 * ------------------------------      decrease exceptions by revealing compile-time faults.
 * 
 *                                  #| Non-generic collections types are in System.Collections,
 *                                     while generic types are in System.Collections.Generic.
 *                                     
 *                                  #| C# also has several specialized collections tuned to deal with a
 *                                     specific data type, which we can find in the
 *                                     System.Collections.Specialized namespace.
 * 
 */

namespace MyProject_128
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(-2);
            myList.Add(32);
            myList.Add(9);
            myList.Add(24);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
