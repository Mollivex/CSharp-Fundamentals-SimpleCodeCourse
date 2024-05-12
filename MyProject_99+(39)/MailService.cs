using MyProject_138;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_138
{
    // We can easily extend the application further with another subscriber. Let’s create another class called MailService:
    public class MailService
    {
        public void OnFoodPrepared(object sou, FoodPreparedEventArgs eventArgs)
        {
            Console.WriteLine($"MailService: your food '{eventArgs.Order.Item}' is prepared.");
        }
    }
    // This class is almost the same as the AppService, we’ve changed the output slightly so we can see what happens in the console.
}
