using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * ==============================================
 * Multithreading in C# | Passing data to threads
 * ==============================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/standard/threading/creating-threads-and-passing-data-at-start-time
 *     
 *     The ParameterizedThreadStart delegate provides an easy way to pass an object containing data to a thread when you call Thread.Start(Object).
 *     
 *     Using the ParameterizedThreadStart delegate is not a type-safe way to pass data, because the Thread.Start(Object) method accepts any object. 
 *  An alternative is to encapsulate the thread procedure and the data in a helper class and use the ThreadStart delegate to execute the thread procedure. 
 *  The following example demonstrates this technique:
 *     
 */

namespace MyProject_142
{
    // The ThreadWithState class contains the information needed for a task,
    // and the method that executes the task.
    public class ThreadWithState
    {
        // State information used in the task.
        private string boilerplate;
        private int numberValue;

        // The constructor obtains the state information
        public ThreadWithState(string text, int number)
        {
            boilerplate = text;
            numberValue = number;
        }

        // The thread procedure performs the task, such as formatting and
        // printing a document.
        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, numberValue);
        }
    }
    
    // Entry point for the example.
    public class Program
    {
        static void Main(string[] args)
        {
            // Supply the state information required by the task.
            ThreadWithState tws = new ThreadWithState("This report displays the number: {0}", 42);

            // Create a thread to execute the task, and then start the thread
            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            Console.WriteLine("Main thread does some work, then waits...");
            t.Join();
            Console.WriteLine("Independent task has completed; main thread ends.");
        }
    }
}
/*
 *      Neither ThreadStart nor ParameterizedThreadStart delegate has a return value, because there is no place to return the data from an asynchronous call. 
 *  To retrieve the results of a thread method, you can use a callback method, as shown in the next section.
 */