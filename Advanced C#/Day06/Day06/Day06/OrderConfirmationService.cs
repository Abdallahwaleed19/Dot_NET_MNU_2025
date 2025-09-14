using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class OrderConfirmationService
    {
        public void SendConfirmation(object sender, EventArgs e)
        {
            Console.WriteLine("Order placed successfully!");
        }
    }
}
