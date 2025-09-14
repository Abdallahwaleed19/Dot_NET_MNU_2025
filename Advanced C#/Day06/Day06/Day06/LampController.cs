using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class LampController
    {
        public void TurnOnLamp(int luxLevel)
        {
            Console.WriteLine($"Lamp turned on, lux: {luxLevel}");
        }
        public void LogLightChange(int luxLevel)
        {
            Console.WriteLine($"Light level changed to {luxLevel}");
        }
    }
}
