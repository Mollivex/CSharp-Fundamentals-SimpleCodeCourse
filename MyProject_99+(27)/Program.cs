using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================
 * Generics in C# | Classes and methods 
 * ====================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes
 * 
 *      Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer
 *  the specification of one or more types until the class or method is declared and instatiated by client code. For example, by using
 *  a generic type parameter 'T', you can write a single class that other client code can use without incurring the cost or risk of runtime
 *  casts or boxing operations, as shown here in example below.
 *  
 *      Generic classes and methods combine reusability, type safety, and efficiency in a way that their non-generic couterparts cannot.
 *  Generics are most frequently used with collections and the methods that operate on them. The System.Collections.Generic namespace contains
 *  several generic-based collection classes. The non-generic collections, such as ArrayList are not recommended and are maintained for
 *  compatibility purposes.
 *  
 *      You can also create custom generic types and methods to provide your own generalized solutions and design patterns that are type-safe
 *  and efficient. The following code example, shows a simple generic linked-list class for demonstration purposes.
 *  (In most cases, you should use the 'List<T>' class provided by .NET instead of creating your own.) The type parameter 'T' is used in several
 *  locations where a concrete type would ordinarily be used to indicate the type of the item stored in the list. It is used in the following ways:
 *  
 *              #| As the type of a method parameter in the AddHead method.
 *              #| As the return of the Data property in the nested Node class.
 *              #| As the type of the private member data in the nested class.
 *      
 *      Parameter 'T' is available to the nested Node class. When GenericList<T> is instantiated with a concrete type, for example GenericList<int>, each
 *  occurence of 'T' will be replaced with int.
 * 
 */

namespace MyProject_126
{
    // Declare the generic class.
    public class GenericList1<T>
    {
        public void Add(T input) { }
    }
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            //=================================================================
            // Declare a list of type int
            GenericList1<int> list1 = new GenericList1<int>();
            list1.Add(1);

            // Declare a list of type string
            GenericList1<string> list2 = new GenericList1<string>();
            list2.Add("");

            // Declare a list of type ExampleClass
            GenericList1<ExampleClass> list3 = new GenericList1<ExampleClass>();
            list3.Add(new ExampleClass());
            //================================================================
        }
        // type parameter T in angle brackets
        public class GenericList2<T>
        {
            // The nested class is also generic on T
            private class Node
            {
                // T used in non-generic constructor
                public Node(T t)
                {
                    next = null;
                    data = t;
                }

                private Node? next;
                public Node? Next
                {
                    get { return next; }
                    set { next = value; }
                }

                // T as private member data type
                private T data;

                // T as return type of property
                public T Data
                {
                    get { return data; }
                    set { data = value; }
                }
            }
            private Node? head;

            //constructor
            public GenericList2()
            {
                head = null;
            }

            // T as method parameter type:
            public void AddHead(T t)
            {
                Node n = new Node(t);
                n.Next = head;
                head = n;
            }

            public IEnumerator<T> GetEnumerator()
            {
                Node? current = head;

                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }
    }
}
