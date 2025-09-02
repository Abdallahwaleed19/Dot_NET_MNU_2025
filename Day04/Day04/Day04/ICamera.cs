using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public interface ICamera
    {
        public virtual void TakePhoto() { Console.WriteLine("TakePhoto..."); }
    }
}
