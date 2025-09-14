using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class WaterTank
    {
        public event TankFullHandler TankFull;
        private int waterLevel = 0;
        public void Fill()
        {
            for (int i = 0; i <= 100; i += 10)
            {
                waterLevel = i;
                Console.WriteLine($"Water level: {waterLevel}%");
                if (waterLevel >= 100)
                {
                    OnTankFull();
                }
            }
        }
        protected virtual void OnTankFull()
        {
            TankFull?.Invoke(); 
        }
    }
}
