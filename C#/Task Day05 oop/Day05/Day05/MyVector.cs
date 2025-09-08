using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class MyVector
    {
        public int X;
        public int Y;

        public MyVector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static MyVector operator +(MyVector v1, MyVector v2)
        {
            return new MyVector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static MyVector operator -(MyVector v1, MyVector v2)
        {
            return new MyVector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static bool operator ==(MyVector v1, MyVector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        public static bool operator !=(MyVector v1, MyVector v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}