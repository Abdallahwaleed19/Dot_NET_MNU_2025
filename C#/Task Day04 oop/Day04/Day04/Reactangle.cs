using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Reactangle : Shape, IResizable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving a rectangle.");
        }
        public void Resize()
        {
            Console.WriteLine("Resizing a rectangle.");
        }
    }

}
