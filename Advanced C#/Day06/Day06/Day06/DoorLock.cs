using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class DoorLock
    {
        public event EventHandler<DoorEventArgs> DoorStateChanged;

        public void LockDoor(bool isLocked)
        {
            Console.WriteLine(isLocked ? "Locking door..." : "Unlocking door...");
            DoorStateChanged?.Invoke(this, new DoorEventArgs { IsLocked = isLocked });
        }
    }
}
