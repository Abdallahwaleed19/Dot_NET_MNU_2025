using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Car
    {
        static int TotalCars; 
        readonly String ChessisNumber;
        public String Model; 
        public double Price;
        public Car (string model , double price , string chessisNumber)
        {
            this.Model = model;
            this.Price = price;
            this.ChessisNumber = chessisNumber;
            TotalCars++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Price: {Price}, ChessisNumber: {ChessisNumber}");
            Console.WriteLine($"Total Cars: {TotalCars}");
        }
    }
}
