using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Circle : Shape , IMovable, IResizable
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
        public void Move()
        {
            Console.WriteLine("Moving the circle.");
        }
        public void Resize()
        {
            Console.WriteLine("Resizing the circle.");
        }
    }
}
