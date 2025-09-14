using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public class DoorEventArgs : EventArgs
    {
        public bool IsLocked { get; set; }
    }

}
