using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================================
 * Unsafe code in C# | Pointer types | Function pointers
 * =====================================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code
 *      
 *      Most of the C# code you write is 'verifiably safe code'. Verifiable safe code .NET tools can verify that the code is safe. In general, safe code doesn't directly
 *  access memory using pointers. It also doesn't allocate raw memory using pointers. It also doesn't allocate raw memory. It creates managed objects instead.
 *  
 *      C# supports an unsafe context, in which you may write unverifiable code. In an unsafe context, code may use pointers, allocate and free blocks of memory, and call 
 *  methods using function pointers. Unsafe code in C# isn't necessarily dangerous; it's just code whose safety cannot be verified.
 *  
 *  -!- Unsafe code has the following properties:
 *      
 *          #| Methods, types and code blocks can be defined as unsafe.
 *          #| In some cases, unsafe code may increase an application's performance by removing array bounds checks.
 *          #| Unsafe code is required when you call native functions that require pointers.
 *          #| Using unsafe code introduces security and stability risks.
 *          #| The code that contains unsafe blocks must be compiled with the AllowUnsafeBlocks compiler option.
 * 
 * --------------
 * Pointer Types:   In an unsafe context, a type may be a pointer type, in addition to value type, or a reference type.
 * --------------   A pointer type declaration takes one of the following forms:
 *                                      
 *                                      type* identifier;
 *                                      void* identifier; // allowed but not recommended
 *      
 *      The type specified before the '*' in a pointer type is called the referent type. Only an unmanaged type can be a referent type.
 *      
 *      Pointer types don't inherit from object and no conversions exist between pointer types and object. Also, boxing and unboxing don't support pointers.
 *  However, you can convert between different pointer types and between pointer types and integral types.
 *  
 *      When you declare multiple pointers in the same declaration, you write the asterisk(*) together with the underlying type only. It isn't used as 
 *  a prefix to each pointer name. For example:
 *  
 *                                      int* p1, p2, p3;    // OK!
 *                                      int *p1, *p2, *p3;  // Invalid in C#
 *      
 *      A pointer can't point to a reference or to a struct that contains references, because an object reference can be garbage collected even if a pointer
 *  is pointing to it. The garbage collector doesn't keep track of whether an object is being pointed to by any pointer types.
 *  
 *      The value of the pointer variable of type MyType* is the address of a variable of type MyType. The following are examples of pointer type declarations:
 *                                      
 *                                  #| int* p   : 'p' is a pointer to an integer.   
 *                                  #| int** p  : 'p' is a pointer to a pointer to an integer
 *                                  #| int*[] p : 'p' is single-dimensional array of pointers to integers
 *                                  #| char* p  : 'p' is a pointer to a char
 *                                  #| void* p  : 'p' is a pointer to an unknown type
 * 
 *      The pointer indirection operator '*' can be used to access the contents at the location pointed to by the pointer variable.
 * 
 * ----------------------------------------------
 * How to use pointers to copy an array of bytes:
 * ----------------------------------------------
 * 
 *      The following example uses pointers to copy bytes from one arrays to another.
 *      
 *      This example uses the unsafe keyword, which enables you to use pointers in the Copy method. The fixed statement is used to declare pointer to the source 
 *  and destination arrays. The fixed statement pins the location of the source and destination arrays in memory so that they will not be moved by garbage collection.
 *  The memory blocks for the arrayts are unpinned when the fixed block is completed. Because the Copy method in this example uses the unsafe keyword it must be compiled
 *  with the AllowUnsafeBlocks compiler option.
 *  
 *      This example accesses the elemtns of both arrays using indices rather than a second unmanaged pointer. The declaration of the pSource and pTarget pointers pins the arrays.
 * 
 */

namespace MyProject_140
{
    class Program
    {
        static unsafe void Copy(byte[] source, int sourceOffset, byte[] target, int targetOffset, int count)
        {
            // If either array is not instantiated, you cannot complete the copy.
            if ((source == null) || (target == null))
            {
                throw new System.ArgumentException("source or target is null");
            }

            // If either offset, or the number of bytes to copy, is negative, you
            // cannot complete the copy.
            if ((sourceOffset < 0) || (targetOffset < 0) || (count < 0))
            {
                throw new System.ArgumentException("offset or bytes to copy is negative");
            }

            // If the number of bytes from the offset to the end of the array is
            // less than the number of bytes you want to copy, you cannot complete
            // the copy.
            if ((source.Length - sourceOffset < count) ||
                (target.Length - targetOffset < count))
            {
                throw new System.ArgumentException("offset to end of array is less than bytes to be copied");
            }

            // The following fixed statement pins the location of the source and
            // target objects in memory so that they will not be moved by garbage
            // collection.
            fixed (byte* pSource = source, pTarget = target)
            {
                // Copy the specified number of bytes from source to target.
                for (int i = 0; i < count; i++)
                {
                    pTarget[targetOffset + i] = pSource[sourceOffset + i];
                }
            }
        }
        static void Main(string[] args)
        {
            // Create two arrays of the same length:
            int length = 100;
            byte[] byteArray1 = new byte[length];
            byte[] byteArray2 = new byte[length];

            // Fill byteArray1 with 0 - 99:
            for (int i = 0; i < length; i++)
            {
                byteArray1[i] = (byte)i;
            }

            // Display the first 10 elements in byteArray1:
            Console.WriteLine("The first 10 elements of the original are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(byteArray1[i] + " ");
            }
            Console.WriteLine("\n");

            // Copy the contents of byteArray1 to byteArray2:
            Copy(byteArray1, 0, byteArray2, 0, length);

            // Display the first 10 elements in the copy, byteArray2:
            Console.WriteLine("The first 10 elements of the copy are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(byteArray2[i] + " ");
            }
            Console.WriteLine("\n");

            // Copy the contents of the last 10 elements of byteArray1 to the beginning of byteArray2.
            // The offset specifies where the copying begins in the source array
            int offset = length - 10;
            Copy(byteArray1, offset, byteArray2, 0, length - offset);

            // Display te first 10 elements in the copy, byteArray2:
            Console.WriteLine("The first 10 elements of the copy are:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(byteArray2[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
