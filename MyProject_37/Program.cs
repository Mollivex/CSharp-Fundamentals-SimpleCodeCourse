using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Indexes and ranges in C#8 .Core framework
 * 
 */

namespace MyProject_37
{
    internal class Program
    {
        static void Main()
        {
            int[] myArray1 = { 1, 82, 31, 41, 24, 11, 2, 4, 53, 34, 211, 52, 24, 2, 1, 57 };

            // With a special symbol [ ^ (XOR)], print position 1 element from the END of array //
            Console.WriteLine(myArray1[^1]);

            // To extract an array from another with defined RANGE //
            
            int[] myArray2 = myArray1[1..5]; // or [..4] or [2..]
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.Write("\n{0} ",myArray2[i]);
            }
            Console.WriteLine("\n");

            // How is symbol [ ^ (XOR)] works //

            Index myIndex = new Index(3,true); // ^3

            Console.Write(myArray1[myIndex]);
            Console.WriteLine();
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            // How is RANGE works //

            Range myRange = new Range(1,4); // 1..4
            int[] myArray3 = myArray1[myRange];
            Console.WriteLine();

            // RANGE in string data type (string is an array with group of elements chars'')

            string str = "Hello world, life is beautiful !!! =)";
            Console.WriteLine(str[..5]); // Hello
            Console.WriteLine(str[..11]); // Hello world
            Console.WriteLine(str[^2..]); // =)
            Console.WriteLine(str[^16..^7]); // beautiful

            Console.WriteLine();

            // Examples of extracting ranges of elements from array with printing to console (foreach Loop) 

            Console.WriteLine("foreach Loop examples");

            int[] myArr = { 123, 412, 52, 2, 4, 21, 2, 342, 44, 3, 2, 8795, 5 };

            foreach (var item in myArr[..4])
                Console.Write($"{item} ");
            Console.WriteLine("\n");

            foreach (var item in myArr[4..])
                Console.Write($"{item} ");
            Console.WriteLine("\n");

            foreach (var item in myArr[5..7])
                Console.Write($"{item}");
            Console.WriteLine("\n");

            // foreach Loop can be used with every element which realised IEnumerable

            Console.WriteLine();
        }
    }
}
