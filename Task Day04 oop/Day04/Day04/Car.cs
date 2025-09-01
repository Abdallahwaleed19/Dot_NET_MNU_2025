using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Car
    {
        public static int TotalCars;
        public readonly String Chessisnumber;
        public string Model; 
        public double Price;
        public Car (string Chessisnumber, string model, double price)
        {
            this.Chessisnumber = Chessisnumber;
            TotalCars++;
            Model = model;
            Price = price;
            Console.WriteLine($"Car {Chessisnumber} created. and his model is {model} and his price {price}");
        }
    }
}
