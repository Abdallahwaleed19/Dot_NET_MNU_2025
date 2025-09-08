using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class CreditCardPayment : Payment
    {
        public int CardNumber;
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount} {Currency} using card number {CardNumber}");
        }
    }
}
