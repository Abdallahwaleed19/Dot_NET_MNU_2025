using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class Box<T>
    {
        public T Item;
        public Box(T item)
        {
            Item = item;
        }
        public void showinfo()
        {
            Console.WriteLine(Item);
            Console.WriteLine($"Type of T is: {typeof(T)}");
            Console.WriteLine($"Value of Item is: {Item}");
            Console.WriteLine("-------------------------");
        }
    }
}
