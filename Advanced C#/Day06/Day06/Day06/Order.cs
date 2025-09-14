using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class Order
    {
        public event EventHandler OrderPlaced;

        public void PlaceOrder()
        {
            Console.WriteLine("\nPlacing order...");
            OrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}
