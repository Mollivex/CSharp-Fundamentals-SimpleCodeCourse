using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * ===================================
 * Delegates in C# | Declaring | Using
 * ===================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates?source=recommendations
 *      https://www.tutorialspoint.com/csharp/csharp_delegates.html
 *      
 *      C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method.
 *  The reference can be changed at runtime.
 *  
 *      Delegates are especially for implementing events and the call-back methods. All delegates are implicitly derived from the System.Delegate class.
 *      
 *      A delegate is a type that respresents references to methods with a particular parameter list and return type. When you instantiate a delegate,
 *  you can associate its instance with any method with compatible signature and return type. You can invoke (or call) the method through the delegate instance.
 *  
 *      Delegates are used to pass methods as arguments to other methods. Event handlers are nothing nothing more than methods that are invoked through delegates.
 *  You create a custom method, and a class such as a windows control can call your method when a certain event occurs.
 *      
 * -------
 * Syntax:  [access modifier] delegate [return type] [delegateName] ([parameters])
 * -------
 *          The following example shows a delegate declaration:
 *  
 *                public delegate int PerformCalculation(int x, int y);
 * 
 * -------------------
 * Delegates Overview:   #| Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and unlike C++ pointers
 * -------------------      to member functions, delegates encapsulated both an object instance and a method.
 * 
 *                       #| Delegates allow methods to be passed as parameters
 *                       
 *                       #| Delegates can be used to define callback methods
 *                       
 *                       #| Delegates can be chained together; for example, multiple methods can be called on a single event.
 *                       
 *                       #| Methods don't have to match the delegate type exactly.
 *                       
 *                       #| Lambda expressions are more concise way of writing inline code blocks. Lambda expressions (in certain contexts) are 
 *                          compiled to delegate types.
 * 
 * NOTE: In context of method overloading, the signature of a method doesn't include the return value. But in the context of delegates, the signature
 *       does include the return value. In other words, a method must have the same return type as the delegate.
 * 
 */

// Using the BookStore classe:
namespace MyProject_135
{
    using BookStore;

    /// <summary>
    /// Class to total and average prices of books:
    /// </summary>
    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }
        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }
    /// <summary>
    /// Class to test the book database:
    /// </summary>
    class Test
    {
        /// <summary>
        /// Print the title of the book
        /// </summary>
        /// <param name="book"></param>
        static void PrintTitle(Book book)
        {
            Console.WriteLine($"      {book.Title}");
        }
        /// Execution starts HERE!!!
        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();

            // Initialize the database with some books:
            AddBooks(bookDB);

            // Print all the titles of paperback:
            Console.WriteLine("PaperBack Book Title:");

            // Create a new delegate object associated with the static method Test.PrintTitle:
            bookDB.ProcessPaperbackBooks(PrintTitle);

            // Get the average price of a paperback by using a PriceTotaller object:
            PriceTotaller totaller = new PriceTotaller();

            // Create a new delegate object associated with the non-static methpd AddBookToTotal on the object totaller:
            bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);

            Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice());
            
        }
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }
    }
}
