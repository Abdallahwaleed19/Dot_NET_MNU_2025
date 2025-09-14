using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class LightSensor
    {
        public event LightChangedHandler LightChanged;

        public void SetLightLevel(int level)
        {
            Console.WriteLine($"Setting light level to {level}");
            LightChanged?.Invoke(level);
        }

    }
}
