using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class CoffeeMachine
    {
        public async Task BrewCoffeeAsync()
        {
            Console.WriteLine("Starting to brew coffee...");
            await Task.Delay(3000); 
            Console.WriteLine("Coffee is ready!");
        }
    }
}
