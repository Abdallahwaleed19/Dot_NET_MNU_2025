using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class SmartPhone : Phone , ICall, ICamera
    {
        public SmartPhone(String serialNumber) : base(serialNumber)
        {
        }
        public void Call(String phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }
        public void TakePhoto(String photoName)
        {
            Console.WriteLine($"Taking photo {photoName}...");
        }
    }
}
