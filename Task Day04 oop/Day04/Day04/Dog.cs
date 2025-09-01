using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine($"Dog {Name} created.");
        }
        public void Bark()
        {
            Console.WriteLine($"Dog {Name} is barking.");
        }
    }
}
