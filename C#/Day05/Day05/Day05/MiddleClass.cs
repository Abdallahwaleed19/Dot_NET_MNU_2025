using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class MiddleClass : BaseClass
    {
        public sealed override void ShowMessage()
        {
            Console.WriteLine("Message from MiddleClass");
        }
    }
}
