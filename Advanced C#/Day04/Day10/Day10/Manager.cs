using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Manager : Worker
    {
        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
