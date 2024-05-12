using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * ===========================================
 * Events in C# | Declaration | Using | Syntax
 * ===========================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/events-overview
 *      https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/
 *      https://learn.microsoft.com/en-us/dotnet/standard/events/#events
 * 
 *      The event is an encapsulated delegate. C# and .NET both support the events with the delegates. When the state of the application changes, events and delegates 
 *  give the notification to the client application. Delegates and Evenets bothe are tightly coupled for dispatching the events, and event handling require the 
 *  implementation of the delegates. The sending event class is known as the publisher, and the receiver class or handling the Event is known as a subscriber.
 * 
 *      An event is a message sent by an object to signal the occurence of an action. The action can be caused by user interaction, such as a button click, or it can
 *  result from some other program logic, such as changing a property's value.
 *  
 *  -------
 *  Syntax:  [access modifier] event [delegateName] [eventName]
 *  -------
 *  
 * #NOTE: In the base of any event it need to be delegate!
 *        Order to implement an event: - define a delegate
 *                                     - define an event that relies on that delegate
 *                                     - raise an event
 *      
 *      To define an event, you use the C# event or the Visual Basic Event keyword in the signature of your event class, and specify the type of delegate for the event.
 * 
 * ------------------------
 * Key Points about Events:     #| In C#, event handler will take the two parameters as input and return the void.
 * ------------------------     
 *                              #| The first parameter of the Event is also known as the source, which will publish the object.
 *                              
 *                              #| The publisher will decide when we have to raise the Event, and the subscriber will determine what
 *                                 response we have to give.
 *                              
 *                              #| Event can contain many subscribers.
 *                              
 *                              #| Generally, we used Event for the single user action like clicking on the button.
 *                              
 *                              #| If the Event includes the multiple subscribers, then synchronously event handler invoked.
 * 
 *   USING EVENTS EXAMPLE below:   https://code-maze.com/csharp-events/
 * 
 */

namespace MyProject_138
{

    // As we’ve mentioned before, we use EventArgs to send the event data. We can create our own specific event arguments
    // called FoodPreparedEventArgs derived form EventArgs in order to send data to subscribers:
    public class FoodPreparedEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Item = "Pizza with extra cheese" };

            var orderingService = new FoodOrderingService();
            var AppService = new AppService();
            var MailService = new MailService();

            orderingService.FoodPrepared += AppService.OnFoodPrepared;
            orderingService.FoodPrepared += MailService.OnFoodPrepared;
            
            orderingService.PrepareOrder(order);

            Console.WriteLine();
        }
    }
}
