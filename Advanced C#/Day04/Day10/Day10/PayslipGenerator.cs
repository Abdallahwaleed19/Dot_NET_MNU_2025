using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class PayslipGenerator : IPayslipGenerator
    {
        public void GeneratePayslip(Worker worker)
        {
            Console.WriteLine($"Employee: {worker.Name}, Role: {worker.Role}, Salary: {worker.Salary}");
        }
    }
}
