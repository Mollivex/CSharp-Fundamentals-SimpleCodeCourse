using MyProject_138;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_138
{
    // We’ve just created a simple class called AppService, that has one method with a signature same as our event delegate.
    public class AppService
    {
        public void OnFoodPrepared(object source, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"AppService: your food '{eventArgs.Order.Item}' is prepared.");
        }
    }
    // This is exactly what we want. We didn’t have to inject the AppService in the FoodOrderingService class or change its implementation in any way.
}
