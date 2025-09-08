using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class PayPallPayment : Payment
    {
        public string Email;
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount} {Currency} using email {Email}");
        }
    }
}
