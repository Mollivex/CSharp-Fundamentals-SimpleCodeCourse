using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================================
 * Generics in C# | Performance | List vs ArrayList
 * ================================================
 * 
 *      The ArrayList class is used to declare an ArrayList in C#. An ArrayList stores object references in it. This means that an ArrayList can store data
 *  of multiple types like integer, string, float, etc., in it.
 *  
 *      The generic lists are used to hold data for one specific data type in C#. The List class is used to declare a list of a specific data type in C#.
 *  We need specify the data type of our list during declaration.
 * 
 *      The List class must always be preffered over the ArrayList class because of the casting overhead in the ArrayList class. The List class can save us
 *  from run-time errors faced due to the different data types of the ArrayList class elements. The lists are also very easy-to-use with LINQ.
 * 
 */

namespace MyProject_129
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
