using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      The following example illustrates declaring, instantiating, and using a delegate. The BookDB class encapsulates a bookstore database that maintains a database of books.
 *  It exposes a method, 'ProcessPaperbackBooks', which finds all paperback books in the database and calls a delegate for each one. The delegate type that is used is named 'ProcessBookCallback'.
 *  The Test class uses this class to print the titles and average price of the paperback books.
 * 
 *      The use of delegates promotes good separation of functionality between the bookstore database and the client code. The client code has no knowledge of how the books are stored or how the
 *  bookstore code finds paperback books. The bookstore code has no knwoledge of what processing is performed on the paperback books after it finds them.
 */

// A set of classes for handling a bookstore:
namespace BookStore
{
    /// <summary>
    /// Describes a book in the book list:
    /// </summary>
    public struct Book
    {
        public string Title;    // Title of the book
        public string Author;   // Author of the book
        public decimal Price;   // Price of the book
        public bool Paperback;  // Is it paperback?

        public Book(string title, string author, decimal price, bool paperBack)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.Paperback = paperBack;
        }
    }

    // Declare a delegate type for processing a book:
    public delegate void ProcessBookCallBack(Book book);

    // Maintains a book database.
    public class BookDB
    {
        // List of all books in the database:
        ArrayList list = new ArrayList();

        // Add a book to the database:
        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price, paperBack));
        }

        // Call a passed-in delegate on each paperback book to process it:
        public void ProcessPaperbackBooks(ProcessBookCallBack processBook)
        {
            foreach (Book book in list)
            {
                if (book.Paperback)
                    // Calling the delegate:
                    processBook(book);
            }
        }
    }
}
