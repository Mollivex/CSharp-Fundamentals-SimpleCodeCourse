using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================
 * Indexers in C# | Using | Overloading
 * ====================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
 *      https://www.tutorialspoint.com/csharp/csharp_indexers.htm
 * 
 *      Indexers allows instances of a class or struct to be indexed just like arrays. The indexed value can be set or retrieved without explicitly specifying a type
 *  or instance member. Indexers resemble properties except that their accessors take parameters.
 * 
 * -------
 * Syntax:  A one dimensional indexer has the following syntax - 
 * -------
 *                  elementType this[int index]
 *                  {
 *                      get
 *                      {
 *                          // return the value specified by index
 *                      }
 *                      set
 *                      {
 *                          // set the value specified by index
 *                      }
 *                  }
 *                  
 * ------------------
 * Indexers Overview:   #| Indexers enable objects to be indexed in similar manner to arrays.
 * ------------------   
 *                      #| A 'get' accessor returns a value. A 'set' accessor assigns a value.
 *                      
 *                      #| The 'this' keyword is used to define the indexer.
 *                          
 *                                  // Indexer declaration
 *                                  public int this[int index]
 *                                  {
 *                                      //get and set accessors
 *                                  }
 *                      
 *                      #| The 'value' keyword is used to define the value being assigned by the 'set' accessor.
 *                      
 *                      #| Indexers don't have to be indexed by an integer value; it's up to you how to define the
 *                         specific look-up mechanism.
 *                      
 *                      #| Indexers can be overloaded.
 *                      
 *                      #| Indexers can have more than one formal parameter, for example, when accessing a 
 *                         two-dimensional array.
 *     
 *      Indexers are syntactic convenience that enable you to create a class, struct, or interface that client applications can access as an array. The compiler will 
 *  generate an Item property (or an alternatively named property if IndexerNameAttribute is present), and the appropriate accessor methods. Indexers are most frequently
 *  implemented in types whose primary purpose is to encapsulate an internal collection of array.
 *    
 * ----------------------------
 * Indexing using other values:     C# doesn't limit the indexer parameter type to integer. For example, it may be useful to use a string with an indexer.
 * ----------------------------     Such an indexer might be implemented by searching for the string in the collection, and returning the appropriate value. 
 *                                  As accessors can be overloaded, the string and integer version can coexist.
 *      
 */

namespace MyProject_134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Example_#1------------------------------");
            var tempRecord = new TempRecord();

            // Use the indexer's set accessor
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            // Use the indexer's get accessor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }
            Console.WriteLine("--------------------------------------------------------------");

            Console.ReadLine();

            Console.WriteLine("-----------------------Example_#2------------------------------");
            var week1 = new DayCollection();
            Console.WriteLine(week1["Sat"]);

            try
            {
                Console.WriteLine(week1["Made-up day"]);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"Not supported input: {exception.Message}");
            }
            Console.WriteLine("--------------------------------------------------------------");
            
            Console.ReadLine();

            Console.WriteLine("-----------------------Example_#3------------------------------");
            var week2 = new DayOfWeekCollection();
            Console.WriteLine(week2[DayOfWeek.Monday]);

            try
            {
                Console.WriteLine(week2[(DayOfWeek)43]);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"Not supported input: {exception.Message}");
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
