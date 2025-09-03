using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Device
    {
        readonly String SerialNumber;
        public Device(String serialNumber)
        {
            this.SerialNumber = serialNumber;
        }
        public void turnOn()
        {
            Console.WriteLine($"Device {SerialNumber} is turned on.");
        }
    }
}
