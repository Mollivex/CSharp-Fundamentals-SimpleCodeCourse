using MyProject_138;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 *      As we can see we get the order we need to prepare, simulate a 4-second wait in order to see something’s happening and then 
 *  we send a notification to the user application that the order is prepared. Of course, this is only the demo so the example 
 *  is rather simple and we use console output to simulate the notification. This would include many more steps in the real application.
 * 
 */


namespace MyProject_138
{
    // Then, we have an actual service that processes our orders:
    public class FoodOrderingService
    {
        // declaring the event
        public event EventHandler<FoodPreparedEventArgs> FoodPrepared;
        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your order '{order.Item}', please wait...");
            Thread.Sleep(4000);

            OnFoodPrepared(order);
        }
        protected virtual void OnFoodPrepared(Order order)
        {
            FoodPrepared?.Invoke(this, new FoodPreparedEventArgs { Order = order });
        }
    }
}
