using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public interface IMovable
    {
        public virtual void Move() { Console.WriteLine("Moving..."); }
    }
}
