using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class DoorSystem
    {
        public void ShowDoorStatus(object sender, DoorEventArgs e)
        {
            Console.WriteLine(e.IsLocked ? "Door is locked!" : "Door is unlocked!");
        }
        public void PlayLockSound(object sender, DoorEventArgs e)
        {
            if (e.IsLocked)
            {
                Console.WriteLine("Lock sound played!");
            }
        }
    }
}
