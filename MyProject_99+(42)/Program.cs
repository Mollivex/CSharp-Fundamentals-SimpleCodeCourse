using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * =========================================
 * Multithreading in C# | Creating a thread
 * =========================================
 *
 *      https://learn.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading
 *      https://learn.microsoft.com/en-us/dotnet/standard/threading/threads-and-threading
 *      https://learn.microsoft.com/en-us/dotnet/standard/threading/creating-threads-and-passing-data-at-start-time
 *      
 *      Multithreading allows you to increase the responsiveness of your application and, if your applicatio runs on a multiprocessor or multi-core system,
 *  increase its throughput.
 * 
 *      With .NET, you can write applications that perform multiple operations at the same time. Operations with the potential of hodling up other operations
 *  can execute on separate threads, a process known as multithreading or free threading.
 *  
 *      Applications that use multithreading are more responsive to user input because the user interface stays active as processor-intensive tasks execute on 
 *  separate threads. Multithreading is also useful when you create scalable applications because you can add threads as the workload increases.
 * 
 * ------------------
 * Creating a thread:       Creating a new Thread object creates a new managed thread. The Thread class has constructors that take a ThreadStart delegate or
 * ------------------   a ParameterizedThreadStart delegate; the delegate wraps the method that is invoked by the new thread when you call the Start method. 
 *                      Calling Start more than once a ThreadStateException to be thrown.
 *                      
 *                          The Start method returns immediately, often before the new thread has actually started. You can use the ThreadState and IsAlive properties
 *                      to determine the state of the thread at any one moment, but these properties should never be used for synchronizing the activities of threads
 *
 *  #NOTE: Once a thread is started, it's not necessary to retain a reference to the Thread object. The thread continues to execute until the thread procedure ends.
 *      
 *      You create a new thread by creating a new instance of the System.Threading.Thread class. You provide the name of the method that you want to execute on the new
 *  thread to the constructor. To start a created thread, call the Thread.Start method.
 * 
 * 
 */

namespace MyProject_141
{
    public class ServerClass
    {
        // The method that will be called when the thread is started
        public void InstanceMethod()
        {
            Console.WriteLine("ServerClass.InstanceMethod is running on another thread.");

            // Pause for a moment to provide a delay to make threads more apparent
            Thread.Sleep(1000);
            Console.WriteLine("The instance method called by the worker thread has ended.");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("ServerClass.StaticMethod is running on another thread.");

            // Pause for a moment to provide a delay to make threads more apparent.
            Thread.Sleep(5000);
            Console.WriteLine("The instance method called by the worker thread has ended.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ServerClass serverObject = new ServerClass();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a ThreadStart delegate.
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));

            // Starts the thread.
            InstanceCaller.Start();

            Console.WriteLine("The Main() thread calls this after " + "starting the new InstanceCaller thread");

            // Create the thread object, passing in the serverObject.Static
            // method using a ThreadStart delegate.
            Thread StaticCaller = new Thread(new ThreadStart(ServerClass.StaticMethod));

            // Start the thread.
            StaticCaller.Start();

            Console.WriteLine("The Main() thread calls this after " + "starting the new StaticCaller thread");

        }
    }
}
