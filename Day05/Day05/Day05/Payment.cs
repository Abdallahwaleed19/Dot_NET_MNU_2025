using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Payment
    {
        public double Amount; 
        public string Currency;
        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }
    }
}
