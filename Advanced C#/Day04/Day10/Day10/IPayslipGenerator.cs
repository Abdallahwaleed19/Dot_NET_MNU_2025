using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public interface IPayslipGenerator
    {
        void GeneratePayslip(Worker worker);
    }
}
